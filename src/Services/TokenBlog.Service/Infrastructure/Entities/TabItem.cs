using Masa.BuildingBlocks.Ddd.Domain.Entities;

namespace TokenBlog.Service.Infrastructure.Entities;

public class TabItem : Entity<Guid>
{
    public int TabId { get; set; }

    public int BloggerId { get; set; }
}
