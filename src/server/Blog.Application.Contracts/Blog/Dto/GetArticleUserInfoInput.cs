namespace Blog.Blog.Dto;

public class GetArticleUserInfoInput : PagedRequestInput
{
    /// <summary>
    /// 搜索条件
    /// </summary>
    public string? Search { get; set; }
}
