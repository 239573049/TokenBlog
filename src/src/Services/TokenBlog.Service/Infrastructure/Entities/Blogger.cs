using Masa.BuildingBlocks.Ddd.Domain.Entities.Full;

namespace TokenBlog.Service.Order.Infrastructure.Entities;

public class Blogger : FullAggregateRoot<int, int>
{
    /// <summary>
    /// 博客标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 博客内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 用户id
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 流量
    /// </summary>
    public int Flow { get; set; }

}
