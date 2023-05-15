namespace Blog.Contracts.Resources;

public class ResourceDto
{
    public Guid Id { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 下载次数
    /// </summary>
    public int DownloadCount { get; set; }

    /// <summary>
    /// 推荐
    /// </summary>
    public int Referee { get; set; }

    /// <summary>
    /// 分享作者
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// 作者外链
    /// </summary>
    public string? Href { get; set; }
}
