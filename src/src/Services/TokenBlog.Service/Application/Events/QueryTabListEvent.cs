using TokenBlog.Service.Order.Infrastructure.Entities;

namespace TokenBlog.Service.Infrastructure.Events;

public record QueryTabListEvent : Event
{
    public List<Tab> Tabs { get; set; } = new();
}