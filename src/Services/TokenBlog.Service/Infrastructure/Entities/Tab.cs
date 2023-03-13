using Masa.BuildingBlocks.Ddd.Domain.Entities;

namespace TokenBlog.Service.Infrastructure.Entities;

/// <summary>
/// 标签
/// </summary>
public class Tab : Entity<Guid>
{
    /// <summary>
    /// 标签名称
    /// </summary>
    public string Name { get; set; }


}
