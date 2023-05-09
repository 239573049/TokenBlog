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
            .Select(x => new CategoryDto(x.Id, x.name, x.description, x.createdTime, x.Count))
            .OrderBy(x => x.createdTime)
            .ToList();
    }
}