using System;

namespace Blog.Eto;

public class ChatGptEto
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
    /// 用户id
    /// </summary>
    public Guid UserId { get; set; }

    public ChatGptEto(bool chatGpt, string content, Guid userId)
    {
        ChatGPT = chatGpt;
        Content = content;
        UserId = userId;
    }
}
