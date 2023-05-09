namespace Blog.Service.Infrastructure.Views;

public class CategoryListView 
{
    public Guid Id { get; set; }
    
    public string name { get; set; }

    public string description { get; set; }

    public DateTime createdTime { get; set; }

    public int Count { get; set; }
}