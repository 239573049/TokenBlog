namespace TokenBlog.Service.Infrastructure.Events;

public record QueryOrderListEvent : Event
{
    public List<Order> Orders { get; set; } = new();
}