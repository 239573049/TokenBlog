namespace Blog.Service.Application.Bloggers;

public class CategoryQueryHandler
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryQueryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    [EventHandler]
    public async Task GetCategoryAsync(GetCategoryQuery query)
    {
        query.Result = (await _categoryRepository.GetListAsync())
            .Select(x => new CategoryDto(x.Id, x.Name, x.Path, x.Description, x.CreatedTime))
            .OrderBy(x => x.createdTime)
            .ToList();
    }
}
