using Volo.Abp.Domain.Entities;

namespace Blog.Blog;

public class TagRelevanceArticle : Entity<Guid>
{
    /// <summary>
    /// 标签Id
    /// </summary>
    public Guid TagId { get; set; }

    /// <summary>
    /// 博客Id
    /// </summary>
    public Guid ArticleId { get; set; }
}