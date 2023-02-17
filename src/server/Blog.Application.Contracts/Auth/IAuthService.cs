using System.Threading.Tasks;

namespace Blog.Auth;

public interface IAuthService
{
    /// <summary>
    /// GitHub授权服务
    /// </summary>
    /// <returns></returns>
    Task<string> GitHubAuthAsync(string code, string state);
}