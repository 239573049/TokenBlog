namespace Blog.Contracts.Blogger;

public interface ICategoryService
{
    Task<List<CategoryDto>> GetListAsync();

    Task CreateAsync(string name, string description);
}