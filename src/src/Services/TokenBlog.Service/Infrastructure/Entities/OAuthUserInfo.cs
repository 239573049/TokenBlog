using Masa.BuildingBlocks.Ddd.Domain.Entities;
using TokenBlog.Contracts.Order.Enum;

namespace TokenBlog.Service.Order.Infrastructure.Entities;

public class OAuthUserInfo :Entity<int>
{
    /// <summary>
    /// 授权类型
    /// </summary>
    public OAuthType Type { get; set; }

    /// <summary>
    /// 平台唯一id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// 绑定id
    /// </summary>
    public int UserInfoId { get; set; }

    public virtual UserInfo UserInfo { get; set; }
}
