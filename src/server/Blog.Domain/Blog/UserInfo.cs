using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Blog.Blog;

public class UserInfo : FullAuditedAggregateRoot<Guid>
{
    public string GitHubId { get; set; }

    public string Avatar { get; set; }

    public string Name { get; set; }

    public string GitHubUrl { get; set; }

    public UserInfo(Guid id, string gitHubId, string avatar, string name, string gitHubUrl) : base(id)
    {
        GitHubId = gitHubId;
        Avatar = avatar;
        Name = name;
        GitHubUrl = gitHubUrl;
    }
}