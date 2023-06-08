namespace Blog.Service.Services;

public class TabService : BaseService<TabService>, ITabService
{
    public async Task CreateAsync(string name)
    {
        var command = new CreateTabCommand(name);
        await eventBus.PublishAsync(command);
    }

    public async Task<List<TabDto>> GetListAsync()
    {
        var query = new GetTabListQuery();
        await eventBus.PublishAsync(query);
        return query.Result;
    }
}
