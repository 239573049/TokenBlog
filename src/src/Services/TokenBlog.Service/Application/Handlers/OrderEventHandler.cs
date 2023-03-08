namespace TokenBlog.Service.Infrastructure.Handlers;

public class OrderEventHandler
{
    readonly IOrderRepository _orderRepository;

    public OrderEventHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    [EventHandler(Order = 1)]
    public async Task HandleAsync(QueryOrderListEvent @event)
    {
        @event.Orders = await _orderRepository.GetListAsync();
    }
}

public class OrderEventAfterHandler : IEventHandler<QueryOrderListEvent>
{

    public Task HandleAsync(QueryOrderListEvent @event, CancellationToken cancellationToken = default)
    {
        //todo query after
        return Task.CompletedTask;
    }
}