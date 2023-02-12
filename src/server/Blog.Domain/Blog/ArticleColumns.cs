using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Blog.Blog;

public class ArticleColumns : Entity<Guid>, IHasCreationTime
{
    /// <summary>
    /// 排序
    /// </summary>
    public int Rank { get; set; }

    public string Title { get; set; }

    public string Href { get; set; }

    public string Icon { get; set; }

    /// <summary>
    /// 父级id
    /// </summary>
    public Guid? ParentId { get; set; }

    protected ArticleColumns()
    {
    }

    public ArticleColumns(string title)
    {
        Title = title;
    }

    public DateTime CreationTime { get; set; }
}