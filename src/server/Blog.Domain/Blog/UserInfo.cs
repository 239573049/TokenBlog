using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Blog.Blog;

public class UserInfo : FullAuditedAggregateRoot<Guid>
{
    public string GiteeId { get; set; }

    public string Avatar { get; set; }

    public string Name { get; set; }

    public string GiteeUrl { get; set; }

    public UserInfo(Guid id, string giteeId, string avatar, string name, string giteeUrl) : base(id)
    {
        GiteeId = giteeId;
        Avatar = avatar;
        Name = name;
        GiteeUrl = giteeUrl;
    }
}