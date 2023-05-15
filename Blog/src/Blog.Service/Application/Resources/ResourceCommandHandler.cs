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
        await _resourceRepository.AddAsync(new Domain.Resources.Aggregates.Resource(dto.Title, dto.Description, dto.Url, dto.UserName, dto.Href));
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
}
