using Blog.Contracts.Resources;
using Blog.Service.Application.Resources.Commands;
using Blog.Service.Application.Resources.Queries;
using Microsoft.AspNetCore.Authorization;

namespace Blog.Service.Services;

public class ResourceService : BaseService<ResourceService>
{
    public async Task<PaginatedListBase<ResourceDto>> GetListAsync(string? keywords, int page, int pageSize)
    {
        var query = new GetResourceListQuery(keywords, page, pageSize);
        await eventBus.PublishAsync(query);
        return query.Result;
    }

    [Authorize]
    public async Task CreateAsync(CreateResourceDto dto)
    {
        var command = new CreateResourceCommand(dto);
        await eventBus.PublishAsync(command);
    }

    public async Task PraiseAsync(Guid id)
    {
        var command = new PraiseCommand(id);
        await eventBus.PublishAsync(command);
    }

    public async Task<string> DownloadAsync(Guid id)
    {
        var command = new DownloadCommand(id);
        await eventBus.PublishAsync(command);
        if (command.Url.IsNullOrWhiteSpace())
        {
            throw new UserFriendlyException("未找到资源");
        }

        return command.Url;
    }

    public async Task DeleteAsync(Guid id)
    {
        var command = new DeleteResourceCommand(id);

        await eventBus.PublishAsync(command);
    }

    public async Task UpdateAsync(UpdateResourceDto dto)
    {
        var command = new UpdateResourceCommand(dto);
        await eventBus.PublishAsync(command);
    }
}
