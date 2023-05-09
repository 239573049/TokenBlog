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

    public async Task<List<Article>> GetListAsync(string? keyword, Guid? categoryId, string? tabIds, int page = 1,
        int pageSize = 20)
    {
        var query = CreateQuery(keyword, categoryId, tabIds);

        return await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public Task<int> GetCountAsync(string? keyword, Guid? categoryId, string? queryTabIds)
    {
        var query = CreateQuery(keyword, categoryId, queryTabIds);

        return query.CountAsync();
    }

    private IQueryable<Article> CreateQuery(string? keyword, Guid? categoryId, string? tabIds)
    {
        return Context.Articles.Where(x =>
                (string.IsNullOrEmpty(keyword) || x.Title.Contains(keyword) || x.Content.Contains(keyword)) &&
                (categoryId == null || x.CategoryId == categoryId) && (string.IsNullOrEmpty(tabIds) ||
                                                                       x.Tabs.Contains(tabIds)))
            .OrderByDescending(x=>x.CreationTime)
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
            .Skip(0)
            .Take(10)
            .ToListAsync();
    }

    public Task UpdateReadCountAsync(Guid id)
    {
        return Context.Database.ExecuteSqlRawAsync(
            $"update \"Articles\" set \"ReadCount\" = \"ReadCount\"+1 where \"Id\" = '{id}'");
    }
}