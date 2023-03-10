using System;
using Volo.Abp.Application.Dtos;

namespace Blog.Dto;

public class GetArticlesDto : EntityDto<Guid>
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
    /// 用户Id
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// 访问浏览
    /// </summary>
    public long Flow { get; set; }

    /// <summary>
    /// 示图
    /// </summary>
    public string PictorialView { get; set; }

    /// <summary>
    /// 点赞
    /// </summary>
    public int Praise { get; set; }
}