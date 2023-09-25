using Masa.Utils.Models;
using WebApiClientCore.Attributes;

namespace Blog.Contracts.Blogger;

public interface IArticleService
{
    [HttpGet("Articles/List")]
    Task<PaginatedListBase<GetArticleListDto>> GetListAsync(string? keyword, Guid? categoryId, string? tabIds,
        int page = 1, int pageSize = 20);

    [HttpGet("Articles/{id}")]
    Task<ArticleDto> GetAsync(int id);


    [HttpGet("Articles/Ranking")]
    Task<List<GetArticleListDto>> GetRankingAsync();


    [HttpPost("Articles")]
    Task CreateAsync(CreateArticleDto dto);


    [HttpDelete("Articles/{id}")]
    Task DeleteAsync(int id);


    [HttpPost("Articles/Like/{id}")]
    Task LikeAsync(int id);
}