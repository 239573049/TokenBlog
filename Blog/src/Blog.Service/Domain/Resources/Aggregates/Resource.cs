using Masa.BuildingBlocks.Ddd.Domain.Entities.Full;

namespace Blog.Service.Domain.Resources.Aggregates;

public class Resource : FullAggregateRoot<Guid, Guid?>
{
    protected Resource(Guid id, string title, string description, string url, int downloadCount, int referee, string? userName, string? href)
    {
        Id = id;
        Title = title;
        Description = description;
        Url = url;
        DownloadCount = downloadCount;
        Referee = referee;
        UserName = userName;
        Href = href;
    }

    public Resource(string title, string description, string url, string? userName, string? href)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        Url = url;
        DownloadCount = 0;
        Referee = 0;
        UserName = userName;
        Href = href;
    }



    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; private set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// 下载地址
    /// </summary>
    public string Url { get; private set; }

    /// <summary>
    /// 下载次数
    /// </summary>
    public int DownloadCount { get; private set; }

    /// <summary>
    /// 推荐
    /// </summary>
    public int Referee { get; private set; }

    /// <summary>
    /// 分享作者
    /// </summary>
    public string? UserName { get; private set; }

    /// <summary>
    /// 作者外链
    /// </summary>
    public string? Href { get; private set; }
}
