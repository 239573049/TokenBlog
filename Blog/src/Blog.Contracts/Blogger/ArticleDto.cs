namespace Blog.Contracts.Blogger;

public class ArticleDto
{
    public int Id { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 发布时间
    /// </summary>
    public DateTime PublishTime { get; set; }

    /// <summary>
    /// 作者Id
    /// </summary>
    public Guid UserId { get; set; }

    public string UserName { get; set; }

    /// <summary>
    /// 阅读量
    /// </summary>
    public int ReadCount { get; set; }

    /// <summary>
    /// 点赞量
    /// </summary>
    public int Like { get; set; }

    /// <summary>
    /// 分类id
    /// </summary>
    public Guid CategoryId { get; set; }

    public DateTime CreationTime { get; set; }

    public string CategoryName { get; set; }

    public string Tabs { get; set; }
}
