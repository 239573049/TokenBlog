using TokenBlog.Service.Infrastructure.Entities;

namespace TokenBlog.Service.Application.Events;

public record QueryTabListEvent : Event
{
    public List<Tab> Tabs { get; set; } = new();
}