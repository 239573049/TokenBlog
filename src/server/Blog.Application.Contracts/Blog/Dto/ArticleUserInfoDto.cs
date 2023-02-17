using System;
using Volo.Abp.Application.Dtos;

namespace Blog.Blog.Dto;

public class ArticleUserInfoDto : EntityDto<Guid>
{
    /// <summary>
    /// 博客标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 发布时间
    /// </summary>
    public DateTime CreationTime { get; set; }

    /// <summary>
    /// 访问浏览
    /// </summary>
    public long Flow { get; set; }

    /// <summary>
    /// 点赞
    /// </summary>
    public int Praise { get; set; }
}
