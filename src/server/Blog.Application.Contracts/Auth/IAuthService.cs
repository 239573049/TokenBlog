using System.Threading.Tasks;

namespace Blog.Auth;

public interface IAuthService
{
    /// <summary>
    /// Gitee授权服务
    /// </summary>
    /// <returns></returns>
    Task<string> GiteeAuthAsync(string code, string state);
}