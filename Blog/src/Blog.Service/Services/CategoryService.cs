using Microsoft.AspNetCore.Authorization;

namespace Blog.Service.Services;

public class CategoryService : BaseService<CategoryService>, ICategoryService
{
    public async Task<List<CategoryDto>> GetListAsync()
    {
        var query = new GetCategoryQuery();
        await eventBus.PublishAsync(query);
        return query.Result;
    }

    [Authorize]
    public async Task CreateAsync(string name,string description)
    {
        var command = new CreateCategoryCommand(name, description);
        await eventBus.PublishAsync(command);
    }
}
