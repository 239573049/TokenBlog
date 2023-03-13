using TokenBlog.Service.Application.Events;
using TokenBlog.Service.Infrastructure.Entities;

namespace TokenBlog.Service.Services;

public class TabService : ServiceBase
{
    public TabService(IServiceCollection services) 
    {
        App.MapGet("/tab/list", QueryList)
            .Produces<List<Tab>>()
            .WithName("GetTabs");
    }

    public async Task<IResult> QueryList(IEventBus eventBus)
    {
        var orderQueryEvent = new QueryTabListEvent();
        await eventBus.PublishAsync(orderQueryEvent);
        return Results.Ok(orderQueryEvent.Tabs);
    }
}