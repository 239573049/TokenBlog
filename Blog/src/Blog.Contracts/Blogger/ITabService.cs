using WebApiClientCore.Attributes;

namespace Blog.Contracts.Blogger;

public interface ITabService
{
    [HttpPost("Tabs")]
    Task CreateAsync(string name);

    [HttpGet("/Tabs/List")]
    Task<List<TabDto>> GetListAsync();
}