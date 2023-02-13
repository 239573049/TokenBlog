using Blog.Blog.Dto;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Blog.Blog;

public interface IArticleService
{
    Task<PagedResultDto<ArticlesDto>?> GetListAsync(GetArticlesInput input);

    /// <summary>
    /// 创建博客
    /// </summary>
    /// <returns></returns>
    Task CreateAsync(CreateArticlesInput input);
}