namespace Blog.Contracts.Blogger;

public class CreateArticleDto
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 分类id
    /// </summary>
    public Guid CategoryId { get; set; }

    public string Tabs { get; set; }
}
