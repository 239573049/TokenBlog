using Blog.Service.Application.Bloggers.Commands;
using Microsoft.AspNetCore.Authorization;

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

    public async Task<ArticleDto> GetAsync(int id)
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

    [Authorize]
    public async Task CreateAsync(CreateArticleDto dto)
    {
        var command = new CreateArticleCommand(dto);
        await eventBus.PublishAsync(command);
    }

    [Authorize]
    public async Task DeleteAsync(int id)
    {
        var command = new DeleteArticleCommand(id);
        await eventBus.PublishAsync(command);
    }

    public async Task LikeAsync(int id)
    {
        var command = new LikeCommand(id);
        await eventBus.PublishAsync(command);
    }
}