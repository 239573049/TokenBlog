using Blog.Contracts.Blogger;
using Masa.Utils.Models;

namespace Blog.Shared.Services;

public class ArticleService : IArticleService
{

    public Task CreateAsync(CreateArticleDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ArticleDto> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PaginatedListBase<GetArticleListDto>> GetListAsync(string? keyword, Guid? categoryId, string? tabIds, int page = 1, int pageSize = 20)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetArticleListDto>> GetRankingAsync()
    {
        throw new NotImplementedException();
    }

    public Task LikeAsync(int id)
    {
        throw new NotImplementedException();
    }
}
