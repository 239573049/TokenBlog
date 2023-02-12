using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Blog.Blog;

public class ArticleComment : Entity<Guid>, IHasCreationTime
{
    /// <summary>
    /// 文章Id
    /// </summary>
    public Guid ArticleId { get; set; }

    /// <summary>
    /// 评论内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreationTime { get; set; }

    /// <summary>
    /// 父级Id
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// 用户id
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// 点赞
    /// </summary>
    public int Praise { get; set; }

    /// <summary>
    /// 踩
    /// </summary>
    public int Trample { get; set; }
}