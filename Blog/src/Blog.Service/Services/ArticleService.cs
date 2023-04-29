namespace Blog.Service.Services;

public class ArticleService : BaseService<ArticleService>
{
    public async Task<PaginatedListBase<GetArticleListDto>> GetListAsync(string? keyword, Guid? categoryId,
        int page = 1, int pageSize = 20)
    {
        var query = new GetArticleListQuery(keyword, categoryId, page, pageSize);
        await eventBus.PublishAsync(query);
        
        return query.Result;
    }
}