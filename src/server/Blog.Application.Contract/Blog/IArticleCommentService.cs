using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Blog.Dto;

namespace Blog.Blog;

public interface IArticleCommentService
{
    /// <summary>
    /// 发布评论
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task CreateAsync(CreateArticleCommentInput input);
    
    /// <summary>
    /// 获取评论列表
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task<List<GetArticleCommentDto>> GetListAsync(GetArticleCommentInput input);
    
    /// <summary>
    /// 删除评论
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);
}
