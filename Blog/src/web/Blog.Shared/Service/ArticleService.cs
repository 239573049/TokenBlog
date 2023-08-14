using Blog.Contracts.Blogger;
using Masa.Utils.Models;

namespace Blog.Shared.Service;

public class ArticleService : BaseService, IArticleService
{
    public async Task<PaginatedListBase<GetArticleListDto>> GetListAsync(string? keyword, Guid? categoryId,
        string? tabIds,
        int page = 1, int pageSize = 20)
    {
        return await GetAsync<PaginatedListBase<GetArticleListDto>>("api/article/list?keyword=" + keyword +
                                                                    "&categoryId=" + categoryId + "&tabIds=" + tabIds +
                                                                    "&page=" + page + "&pageSize=" + pageSize);
    }

    public async Task<ArticleDto> GetAsync(int id)
    {
        return await GetAsync<ArticleDto>("api/article/" + id);
    }

    public Task<List<GetArticleListDto>> GetRankingAsync()
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(CreateArticleDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task LikeAsync(int id)
    {
        throw new NotImplementedException();
    }
}