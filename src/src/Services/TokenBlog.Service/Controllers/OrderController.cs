using TokenBlog.Service.Order.Infrastructure.Entities;

namespace TokenBlog.Service.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrderController : ControllerBase
{
    [HttpGet("/list")]
    public IEnumerable<Tab> List([FromServices] IEventBus eventBus)
    {
        var tabQueryEvent = new QueryTabListEvent();
        eventBus.PublishAsync(tabQueryEvent);
        return tabQueryEvent.Tabs;
    }

}