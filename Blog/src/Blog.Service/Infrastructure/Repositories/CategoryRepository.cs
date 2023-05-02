using Blog.Service.Domain.Bloggers.Repositories;
using Blog.Service.Infrastructure.Views;
using Masa.BuildingBlocks.Data.UoW;
using Masa.Contrib.Ddd.Domain.Repository.EFCore;

namespace Blog.Service.Infrastructure.Repositories;

public class CategoryRepository : Repository<BlogDbContext, Category>, ICategoryRepository
{
    public CategoryRepository(BlogDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

    public async Task<List<CategoryListView>> GetListAsync()
    {
        var result = await Context.Categories
            .Select(x => new CategoryListView()
            {
                Id = x.Id,
                name = x.Name,
                path = x.Path,
                description = x.Description,
                createdTime = x.CreatedTime
            })
            .ToListAsync();

        var categoryIds = result.Select(x => x.Id).ToList();
        var category = Context.Articles
            .Where(x => categoryIds.Contains(x.CategoryId))
            .GroupBy(x => x.CategoryId)
            .Select(x => new
            {
                CategoryId = x.Key,
                Count = x.Count()
            })
            .ToList();

        foreach (var item in result)
        {
            item.Count = category.FirstOrDefault(x => x.CategoryId == item.Id)?.Count ?? 0;
        }

        return result;
    }
}