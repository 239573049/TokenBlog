using System;

namespace Blog.Blog.Dto;

public class GetArticlesInput : PagedRequestInput
{
    public Guid? TagId { get; set; }

    /// <summary>
    /// 搜索条件
    /// </summary>
    public string? Search { get; set; }
}