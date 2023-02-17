using System.Threading.Tasks;

namespace Blog.Users;

public interface IUserInfoService
{
    /// <summary>
    /// 获取基本信息
    /// </summary>
    /// <returns></returns>
    Task<UserInfoDto> GetProfileAsync();
}