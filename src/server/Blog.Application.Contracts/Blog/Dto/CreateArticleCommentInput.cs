using System;

namespace Blog.Blog.Dto;

public class CreateArticleCommentInput
{
    /// <summary>
    /// 文章Id
    /// </summary>
    public Guid ArticleId { get; set; }

    /// <summary>
    /// 评论内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreationTime { get; set; }

    /// <summary>
    /// 父级Id
    /// </summary>
    public Guid? ParentId { get; set; }

}