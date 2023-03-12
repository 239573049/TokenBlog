using Masa.BuildingBlocks.Ddd.Domain.Entities;

namespace TokenBlog.Service.Order.Infrastructure.Entities;

public class TabItem : Entity<Guid>
{
    public int TabId { get; set; }

    public int BloggerId { get; set; }
}
