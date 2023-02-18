namespace Blog.Component.Pages.Module;

public class ChatGptDto
{
    /// <summary>
    /// 是否为ChatGPT
    /// </summary>
    public bool ChatGPT { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 发送时间
    /// </summary>
    public string CreatedTime { get; set; }

}
