namespace TokenBlog.Service.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrderController : ControllerBase
{
    [HttpGet("/list")]
    public IEnumerable<Order> List([FromServices] IEventBus eventBus)
    {
        var orderQueryEvent = new QueryOrderListEvent();
        eventBus.PublishAsync(orderQueryEvent);
        return orderQueryEvent.Orders;
    }

}