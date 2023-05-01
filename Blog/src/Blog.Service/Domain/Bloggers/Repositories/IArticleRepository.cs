namespace Blog.Service.Domain.Bloggers.Repositories;

public interface IArticleRepository : IRepository<Article>
{
    Task<List<Article>> GetListAsync(string? keyword, Guid? categoryId, int page = 1, int pageSize = 20);

    Task<int> GetCountAsync(string? keyword, Guid? categoryId);

    Task<Article?> GetAsync(Guid id);

    /// <summary>
    /// 热榜排名
    /// </summary>
    /// <returns></returns>
    Task<List<Article>> GetRankingAsync();
}