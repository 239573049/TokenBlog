using Blog.Service.Infrastructure.Views;

namespace Blog.Service.Domain.Bloggers.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    Task<List<CategoryListView>> GetListAsync();
}