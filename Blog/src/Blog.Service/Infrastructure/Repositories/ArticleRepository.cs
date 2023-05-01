using Blog.Service.Domain.Bloggers.Aggregates;
using Blog.Service.Domain.Bloggers.Repositories;
using Masa.BuildingBlocks.Data.UoW;
using Masa.Contrib.Ddd.Domain.Repository.EFCore;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Blog.Service.Infrastructure.Repositories;

public class ArticleRepository : Repository<BlogDbContext, Article, Guid>, IArticleRepository
{
    public ArticleRepository(BlogDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

    public async Task<List<Article>> GetListAsync(string? keyword, Guid? categoryId, int page = 1, int pageSize = 20)
    {
        var query = CreateQuery(keyword, categoryId);

        return await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public Task<int> GetCountAsync(string? keyword, Guid? categoryId)
    {
        var query = CreateQuery(keyword, categoryId);

        return query.CountAsync();
    }

    private IQueryable<Article> CreateQuery(string? keyword, Guid? categoryId)
    {
        return Context.Articles.Where(x =>
                string.IsNullOrEmpty(keyword) || x.Title.Contains(keyword) || x.Content.Contains(keyword))
            .Where(x => categoryId == null || x.CategoryId == categoryId)
        .Include(x => x.Category);
    }

    public Task<Article?> GetAsync(Guid id)
    {
        return Context.Articles.Where(x => x.Id == id)
            .Include(x => x.Category).FirstOrDefaultAsync();
    }

    public Task<List<Article>> GetRankingAsync()
    {
        return Context.Articles
            .OrderByDescending(x => x.ReadCount)
            .OrderByDescending(x => x.Like)
            .Skip(0)
            .Take(10)
            .ToListAsync();
    }
}