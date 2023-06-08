using Blog.Contracts.Users;

namespace Blog.Contracts.Blogger;

public interface IUserInfoService
{
    Task CreateAsync(CreateUserInfoDto dto);

    Task<string> Login(string account, string password);
}