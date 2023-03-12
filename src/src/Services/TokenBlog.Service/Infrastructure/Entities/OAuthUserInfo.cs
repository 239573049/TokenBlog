using Masa.BuildingBlocks.Ddd.Domain.Entities;
using TokenBlog.Contracts.Order.Enum;

namespace TokenBlog.Service.Order.Infrastructure.Entities;

public class OAuthUserInfo :Entity<Guid>
{
    /// <summary>
    /// 授权类型
    /// </summary>
    public OAuthType Type { get; set; }

    /// <summary>
    /// 平台唯一id
    /// </summary>
    public int OAuthId { get; set; }

    /// <summary>
    /// 绑定id
    /// </summary>
    public Guid UserInfoId { get; set; }

    public virtual UserInfo UserInfo { get; set; }
}
