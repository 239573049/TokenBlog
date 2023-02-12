using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Blog.Blog;

public class Tag : Entity<Guid>, IHasCreationTime
{
    /// <summary>
    /// 排序
    /// </summary>
    public int Rank { get; set; }

    /// <summary>
    /// 标签标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 专栏id
    /// </summary>
    public Guid ArticleColumnsId { get; set; }

    protected Tag()
    {
    }

    public Tag(string title)
    {
        Title = title;
    }

    public DateTime CreationTime { get; set; }
}