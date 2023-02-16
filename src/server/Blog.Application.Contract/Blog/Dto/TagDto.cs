using System;

namespace Blog.Blog.Dto;

public class TagDto : EntityDto<Guid>
{
    /// <summary>
    /// 排序
    /// </summary>
    public int Rank { get; set; }

    /// <summary>
    /// 标签标题
    /// </summary>
    public string Title { get; set; }
}