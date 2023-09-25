using WebApiClientCore.Attributes;

namespace Blog.Contracts.Blogger;

public interface ICategoryService
{
    [HttpGet("Categories/List")]
    Task<List<CategoryDto>> GetListAsync();

    [HttpPost("Categories")]
    Task CreateAsync(string name, string description);
}