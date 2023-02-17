using Blog.Blog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Blog;

public class EFCoreArticleCommentRepository : EfCoreRepository<BlogDbContext, ArticleComment, Guid>,
    IArticleCommentRepository
{
    public EFCoreArticleCommentRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<List<ArticleCommentView>> GetListAsync(Guid articleId, Guid? parentId)
    {
        var dbContext = await GetDbContextAsync();

        var comments = dbContext.ArticleComments
            .Where(x => x.ArticleId == articleId)
            .Where(x => x.ParentId == parentId);

        var query =
            from comment in comments
            join userInfo in dbContext.UserInfos on comment.UserId equals userInfo.Id
            select new ArticleCommentView(comment.Id)
            {
                ArticleId = comment.ArticleId,
                CreationTime = comment.CreationTime,
                Content = comment.Content,
                ParentId = comment.ParentId,
                UserId = comment.UserId,
                Praise = comment.Praise,
                InfoDto = userInfo,
                Trample = comment.Trample,
            };

        return await query.ToListAsync();
    }
}