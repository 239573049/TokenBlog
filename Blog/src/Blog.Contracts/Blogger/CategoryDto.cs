namespace Blog.Contracts.Blogger;

public class CategoryDto
{
    public Guid Id { get; set; }

    public string name { get; set; }

    public string description { get; set; }

    public DateTime createdTime { get; set; }

    public int count { get; set; }

    public CategoryDto(Guid id, string name, string description, DateTime createdTime, int count)
    {
        Id = id;
        this.count = count;
        this.name = name;
        this.description = description;
        this.createdTime = createdTime;
    }
}