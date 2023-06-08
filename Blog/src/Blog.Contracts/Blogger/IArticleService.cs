using Masa.Utils.Models;

namespace Blog.Contracts.Blogger;

public interface IArticleService
{
    Task<PaginatedListBase<GetArticleListDto>> GetListAsync(string? keyword, Guid? categoryId, string? tabIds,
        int page = 1, int pageSize = 20);

    Task<ArticleDto> GetAsync(int id);


    Task<List<GetArticleListDto>> GetRankingAsync();


    Task CreateAsync(CreateArticleDto dto);


    Task DeleteAsync(int id);


    Task LikeAsync(int id);
}