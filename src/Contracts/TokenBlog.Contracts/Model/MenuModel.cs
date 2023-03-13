namespace TokenBlog.Contracts.Order.Model;

public class MenuModel
{
    public Guid Id { get; set; }
    
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// 跳转
    /// </summary>
    public string Href { get; set; }
}