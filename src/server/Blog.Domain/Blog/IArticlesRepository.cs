using Volo.Abp.Domain.Repositories;

namespace Blog.Blog;

public interface IArticlesRepository : IRepository<Article>
{
    Task<List<Article>> GetListAsync(Guid? tagId, string search, int page = 0, int pageSize = 20);

    Task<int> GetCountAsync(Guid? tagId, string search);
}