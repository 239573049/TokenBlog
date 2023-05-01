using Masa.BuildingBlocks.Ddd.Domain.Entities.Full;

namespace Blog.Service.Domain.Bloggers.Aggregates;

public class Article : FullAggregateRoot<Guid, Guid?>
{
    /// <summary>
    /// 标题
    /// </summary>
    private string title;

    /// <summary>
    /// 内容
    /// </summary>
    private string content;

    /// <summary>
    /// 发布时间
    /// </summary>
    private DateTime publishTime;

    /// <summary>
    /// 作者Id
    /// </summary>
    private Guid userId;

    /// <summary>
    /// 阅读量
    /// </summary>
    private int readCount;

    /// <summary>
    /// 点赞量
    /// </summary>
    private int like;

    /// <summary>
    /// 分类id
    /// </summary>
    private Guid categoryId;

    private string tabs;

    public string Title
    {
        get => title;
        set => title = ArgumentExceptionExtensions.ThrowIfNullOrEmpty(value, nameof(Title));
    }

    public string Content
    {
        get => content;
        set => content = ArgumentExceptionExtensions.ThrowIfNullOrEmpty(value, nameof(Content));
    }

    public DateTime PublishTime
    {
        get => publishTime;
        set => publishTime = value;
    }

    public Guid UserId
    {
        get => userId;
        set => userId = value;
    }

    public int ReadCount
    {
        get => readCount;
        set => readCount = value;
    }

    public int Like
    {
        get => like;
        set => like = value;
    }

    public Guid CategoryId
    {
        get => categoryId;
        set => categoryId = value;
    }

    public string Tabs
    {
        get => tabs;
        set => tabs = value;
    }

    public Article(Guid id, string title, string content, DateTime publishTime, Guid userId, int readCount, int like,
        Guid categoryId, string tabs) : base(id)
    {
        this.title = title;
        this.content = content;
        this.publishTime = publishTime;
        this.userId = userId;
        this.readCount = readCount;
        this.like = like;
        this.categoryId = categoryId;
        this.tabs = tabs;
    }

    public virtual Category? Category { get; set; }
}