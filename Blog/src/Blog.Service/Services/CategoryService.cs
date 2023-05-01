namespace Blog.Service.Services;

public class CategoryService : BaseService<CategoryService>
{
    public async Task<List<CategoryDto>> GetListAsync()
    {
        var query = new GetCategoryQuery();
        await eventBus.PublishAsync(query);
        return query.Result;
    }
}
