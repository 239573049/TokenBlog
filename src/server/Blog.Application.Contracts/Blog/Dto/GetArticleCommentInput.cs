using System;

namespace Blog.Blog.Dto;

public class GetArticleCommentInput
{
    public Guid ArticleId { get; set; }

    public Guid? ParentId { get; set; }
}