using System;

namespace Blog.Users;

public class UserInfoDto : EntityDto<Guid>
{
    public string GitHubId { get; set; }

    public string Avatar { get; set; }

    public string Name { get; set; }

    public string GitHubUrl { get; set; }
}