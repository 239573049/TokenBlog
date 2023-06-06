using Blog.Service.Application.Resources.Commands;
using Blog.Service.Domain.Resources.Repositories;
using Masa.BuildingBlocks.Data.UoW;

namespace Blog.Service.Application.Resources;

public class ResourceCommandHandler
{
    private readonly IResourceRepository _resourceRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ResourceCommandHandler(IResourceRepository resourceRepository, IUnitOfWork unitOfWork)
    {
        _resourceRepository = resourceRepository;
        _unitOfWork = unitOfWork;
    }

    [EventHandler]
    public async Task CreateResourceAsync(CreateResourceCommand command)
    {
        var dto = command.dto;
        await _resourceRepository.AddAsync(
            new Domain.Resources.Aggregates.Resource(dto.Title, dto.Description, dto.Url, dto.UserName, dto.Href));
        await _unitOfWork.SaveChangesAsync();
    }

    [EventHandler]
    public async Task PraiseAsync(PraiseCommand command)
    {
        await _resourceRepository.PraiseAsync(command.id);
    }

    [EventHandler]
    public async Task DownloadAsync(DownloadCommand command)
    {
        var value = await _resourceRepository.DownloadAsync(command.id);

        command.Url = value;
    }

    [EventHandler]
    public async Task DeleteAsync(DeleteResourceCommand command)
    {
        await _resourceRepository.RemoveAsync(x => x.Id == command.id);
        await _unitOfWork.SaveChangesAsync();
    }

    [EventHandler]
    public async Task UpdateAsync(UpdateResourceCommand command)
    {
        var resource = await _resourceRepository.FindAsync(x => x.Id == command.Dto.Id);

        if (resource == null)
        {
            throw new UserFriendlyException("未找到实体");
        }
        
        resource?.Update(command.Dto.Title, command.Dto.Description, command.Dto.Url, command.Dto.UserName,
            command.Dto.Href);

        await _resourceRepository.UpdateAsync(resource);

        await _unitOfWork.SaveChangesAsync();
    }
}