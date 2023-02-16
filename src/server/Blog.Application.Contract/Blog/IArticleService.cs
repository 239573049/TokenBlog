using Blog.Blog.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Blog;

public interface IArticleService
{
    Task<PagedResultDto<ArticlesDto>?> GetListAsync(GetArticlesInput input);

    /// <summary>
    /// 创建博客
    /// </summary>
    /// <returns></returns>
    Task CreateAsync(CreateArticlesInput input);

    /// <summary>
    /// 获取博客详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<GetArticlesDto> GetAsync(Guid id);

    /// <summary>
    /// 热榜数据
    /// </summary>
    /// <returns></returns>
    Task<List<ArticlesDto>> GetTopSearch();
}