using Blog.Blog;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Blog;

public class EFCoreArticlesRepository : EfCoreRepository<BlogDbContext, Article, Guid>, IArticlesRepository
{
    public EFCoreArticlesRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<List<Article>> GetListAsync(Guid? tagId, string? search, int page = 0, int pageSize = 20)
    {
        var query = await CreateQueryAsync(tagId, search);

        return await query.PageBy(page, pageSize).ToListAsync();
    }

    public async Task<int> GetCountAsync(Guid? tagId, string? search)
    {
        var query = await CreateQueryAsync(tagId, search);

        return await query.CountAsync();
    }

    public async Task<ArticleView> GetAsync(Guid id)
    {
        var dbContext = await GetDbContextAsync();

        var query = await dbContext.Articles.Where(x => x.Id == id).Select(x => new ArticleView(x.Id)
        {
            Content = x.Content,
            CreationTime = x.CreationTime,
            CreatorId = x.CreatorId,
            Description = x.Description,
            Flow = x.Flow,
            PictorialView = x.PictorialView,
            Praise = x.Praise,
            Title = x.Title,
            UserId = x.UserId,
            TagId = x.TagId,

        }).FirstOrDefaultAsync();

        return query;
    }

    public async Task<List<Article>> GetTopSearchAsync()
    {
        var dbContext = await GetDbContextAsync();

        // 查询文章排名前十的数据
        return await dbContext.Articles.OrderByDescending(x => x.Flow).Take(10).ToListAsync();
    }

    public async Task UpdateFlowAsync(Guid id)
    {
        var dbContext = await GetDbContextAsync();

        await dbContext.Database.ExecuteSqlRawAsync($"UPDATE Articles SET Flow = Flow+1 WHERE Id = '{id}'");
    }

    private async Task<IQueryable<Article>> CreateQueryAsync(Guid? tagId, string? search)
    {
        var dbContext = await GetDbContextAsync();

        IQueryable<Article> query = null;
        if (tagId != null)
        {
            query = from article in dbContext.Articles
                    where article.TagId == tagId
                    select article;
        }
        else
        {
            query = dbContext.Articles;
        }

        query = query.OrderByDescending(x => x.CreationTime).WhereIf(search?.IsNullOrEmpty() == false, x => x.Title.Contains(search) || x.Description.Contains(search));

        return query;
    }
}