namespace Blog.Service.Domain.Bloggers.Repositories;

public interface IArticleRepository : IRepository<Article>
{
    Task<List<Article>> GetListAsync(string? keyword, Guid? categoryId, string? queryTabIds, int page = 1,
        int pageSize = 20);

    Task<int> GetCountAsync(string? keyword, Guid? categoryId, string? queryTabIds);

    Task<Article?> GetAsync(int id);

    /// <summary>
    /// 热榜排名
    /// </summary>
    /// <returns></returns>
    Task<List<Article>> GetRankingAsync();
    
    /// <summary>
    /// 更新阅读数
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task UpdateReadCountAsync(int id);

    /// <summary>
    /// 推荐
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task UpdateLikeAsync(int id);
}