using Blog.Service.Application.Bloggers.Commands;

namespace Blog.Service.Services;

public class FailarmyService : BaseService<FailarmyService>, IFailarmyService
{
    public async Task CreateAsync(CreateFailarmyDto dto)
    {
        var command = new CreateFailarmyCommand(dto);
        await eventBus.PublishAsync(command);
    }

    public async Task DeleteAsync(Guid id)
    {
        var command = new DeleteFailarmyCommand(id);
        await eventBus.PublishAsync(command);
    }

    public async Task UpdateAsync(UpdateFailarmyDto dto)
    {
        var command = new UpdateFailarmyCommand(dto);
        await eventBus.PublishAsync(command);
    }

    public async Task<PaginatedListBase<FailarmyDto>> GetListAsync(string? keyword, int page = 1,
        int pageSize = 20)
    {
        var query = new GetListFaliarmyQuery(keyword, page, pageSize);
        await eventBus.PublishAsync(query);

        return query.Result;
    }
}