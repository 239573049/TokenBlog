using Masa.BuildingBlocks.Ddd.Domain.Entities.Full;

namespace TokenBlog.Service.Order.Infrastructure.Entities;

public class UserInfo : FullAggregateRoot<Guid, Guid>
{
    /// <summary>
    /// 昵称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 头像
    /// </summary>
    public string Avatar { get; set; }

    /// <summary>
    /// 简介
    /// </summary>
    public string? Intro { get; set; }

    public List<OAuthUserInfo> OAuthUserInfo { get; set; }
}
