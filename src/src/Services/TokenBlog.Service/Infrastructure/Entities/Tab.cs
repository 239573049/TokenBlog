using Masa.BuildingBlocks.Ddd.Domain.Entities;

namespace TokenBlog.Service.Order.Infrastructure.Entities;

/// <summary>
/// 标签
/// </summary>
public class Tab : Entity<int>
{
    /// <summary>
    /// 标签名称
    /// </summary>
    public string Name { get; set; }
}
