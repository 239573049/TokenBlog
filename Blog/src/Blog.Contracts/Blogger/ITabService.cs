namespace Blog.Contracts.Blogger;

public interface ITabService
{
    Task CreateAsync(string name);

    Task<List<TabDto>> GetListAsync();
}