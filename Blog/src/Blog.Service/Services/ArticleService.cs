namespace Blog.Service.Services;

public class ArticleService : BaseService<ArticleService>
{
    public async Task<PaginatedListBase<GetArticleListDto>> GetListAsync(string? keyword, Guid? categoryId,string? tabIds,
        int page = 1, int pageSize = 20)
    {
        var query = new GetArticleListQuery(keyword, categoryId,tabIds, page, pageSize);
        await eventBus.PublishAsync(query);

        return query.Result;
    }

    public async Task<ArticleDto> GetAsync(Guid id)
    {
        var query = new GetArticleQuery(id);
        await eventBus.PublishAsync(query);
        return query.Result;
    }

    public async Task<List<GetArticleListDto>> GetRankingAsync()
    {
        var query = new GetRankingQuery();
        await eventBus.PublishAsync(query);
        return query.Result;
    }
}