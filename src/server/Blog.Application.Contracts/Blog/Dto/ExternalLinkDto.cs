namespace Blog.Blog.Dto;

public class ExternalLinkDto
{
    public string Title { get; set; }

    /// <summary>
    /// 跳转链接
    /// </summary>
    public string ExternalConnection { get; set; }
}