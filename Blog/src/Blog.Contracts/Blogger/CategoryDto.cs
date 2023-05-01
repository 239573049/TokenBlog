namespace Blog.Contracts.Blogger;

public class CategoryDto
{
    public Guid Id { get; set; }

    public string name { get; set; }

    public string path { get; set; }

    public string description { get; set; }

    public DateTime createdTime { get; set; }

    public CategoryDto(Guid id, string name, string path, string description, DateTime createdTime)
    {
        Id = id;
        this.name = name;
        this.path = path;
        this.description = description;
        this.createdTime = createdTime;
    }
}
