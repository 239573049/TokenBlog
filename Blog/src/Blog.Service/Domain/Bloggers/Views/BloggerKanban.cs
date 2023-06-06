namespace Blog.Service.Domain.Bloggers.Views;

public class BloggerKanban
{
    /// <summary>
    /// 博客总数
    /// </summary>
    public int BloggerTotal { get; set; }

    /// <summary>
    /// 今日浏览
    /// </summary>
    public int BrowseToday { get; set; }

    /// <summary>
    /// 浏览量
    /// </summary>
    public int[] SevenDaysTotal { get; set; }

    /// <summary>
    /// 日期
    /// </summary>
    public string[] SevenDaysTitle { get; set; }
    
    /// <summary>
    /// 浏览总量
    /// </summary>
    public int BrowseTotal { get; set; }
}