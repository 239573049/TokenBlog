using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Blog.Blog;

public interface IArticleCommentRepository : IRepository<ArticleComment, Guid>
{
    /// <summary>
    /// 获取评论列表
    /// </summary>
    /// <param name="articleId"></param>
    /// <param name="parentId"></param>
    /// <returns></returns>
    Task<List<ArticleCommentView>> GetListAsync(Guid articleId, Guid? parentId);
}