namespace TokenBlog.Contracts.Order.Model;

public class BloggerModel
{
    public Guid Id { get; set; }
    
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
    public Guid UserId { get; set; }

    /// <summary>
    /// 流量
    /// </summary>
    public int Flow { get; set; }
}