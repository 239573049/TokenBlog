using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Blog;

public class ChatGpt : FullAuditedAggregateRoot<Guid>
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

    /// <summary>
    /// 用户id
    /// </summary>
    public Guid UserId { get; set; }


}
