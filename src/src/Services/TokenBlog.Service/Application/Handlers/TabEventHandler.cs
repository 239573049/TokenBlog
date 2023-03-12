using TokenBlog.Service.Infrastructure.Repositories;

namespace TokenBlog.Service.Infrastructure.Handlers;

public class TabEventHandler
{
    readonly ITabRepository _tabRepository;

    public TabEventHandler(ITabRepository tabRepository)
    {
        _tabRepository = tabRepository;
    }

    [EventHandler(Order = 1)]
    public async Task HandleAsync(QueryTabListEvent @event)
    {
        @event.Tabs = await _tabRepository.GetListAsync();
    }
}

public class OrderEventAfterHandler : IEventHandler<QueryTabListEvent>
{

    public Task HandleAsync(QueryTabListEvent @event, CancellationToken cancellationToken = default)
    {
        //todo query after
        return Task.CompletedTask;
    }
}