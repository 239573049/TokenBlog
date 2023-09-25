using Blog.Contracts.Users;
using WebApiClientCore.Attributes;

namespace Blog.Contracts.Blogger;

public interface IUserInfoService
{
    [HttpPost("UserInfoes")]
    Task CreateAsync(CreateUserInfoDto dto);

    [HttpPost("UserInfoes/Login")]
    Task<string> Login(string account, string password);
}