
namespace Blog.Service.Domain.Bloggers.Aggregates;

public class Category : Entity<Guid>
{
    private string name;

    private string description;

    private DateTime createdTime;

    /// <summary>
    /// 名称
    /// </summary>
    public string Name
    {
        get => name;
        set => name = ArgumentExceptionExtensions.ThrowIfDefault(value, nameof(Name));
    }

    /// <summary>
    /// 描述
    /// </summary>
    public string Description
    {
        get => description;
        set => description = ArgumentExceptionExtensions.ThrowIfDefault(value, nameof(Description));
    }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreatedTime 
    { 
        get => createdTime; 
        set => createdTime = ArgumentExceptionExtensions.ThrowIfDefault(value, nameof(CreatedTime)); 
    }

    protected Category(Guid id, string name, string description, DateTime createdTime)
    {
        Id = id;
        Name = name;
        Description = description;
        CreatedTime = createdTime;
    }

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
        CreatedTime = DateTime.Now;
    }
}
