using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Blog.Blog;

public class ArticleView : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 博客内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 用户Id
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// 访问浏览
    /// </summary>
    public long Flow { get; set; }

    /// <summary>
    /// 点赞
    /// </summary>
    public int Praise { get; set; }

    /// <summary>
    /// 标记
    /// </summary>
    public Guid TagId { get; set; }

    public UserInfo? UserInfo { get; set; }

    public ArticleView(Guid id) : base(id)
    {
    }
}