using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Blog.Blog;

public interface IArticlesRepository : IRepository<Article>
{
    Task<List<Article>> GetListAsync(Guid? tagId, string? search, int page = 0, int pageSize = 20);

    Task<int> GetCountAsync(Guid? tagId, string? search);

    /// <summary>
    /// 获取博客详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<ArticleView> GetAsync(Guid id);

    /// <summary>
    /// 热榜数据
    /// </summary>
    /// <returns></returns>
    Task<List<Article>> GetTopSearchAsync();

    /// <summary>
    /// 更新访问
    /// </summary>
    /// <returns></returns>
    Task UpdateFlowAsync(Guid id);
}