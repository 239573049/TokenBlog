namespace TokenBlog.Service.Infrastructure.Entities;

public class Order
{
    public int Id { get; set; }

    public string OrderNumber { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public DateTimeOffset CreationTime { get; set; } = DateTimeOffset.Now;

    public Order(int id, string orderNumber)
    {
        Id = id;
        OrderNumber = orderNumber;
    }
}