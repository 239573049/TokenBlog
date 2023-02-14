using System;

namespace Blog.Blog.Dto;

public class CreateArticlesInput
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 博客内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 示图
    /// </summary>
    public string PictorialView { get; set; }

    /// <summary>
    /// 标签Id
    /// </summary>
    public Guid TagId { get; set; }
}