using System.Text.RegularExpressions;

namespace Blog.Contracts.Users;

public class CreateUserInfoDto
{
    public CreateUserInfoDto(string name, string account, string password, string email, string? avatar, string role)
    {
        Name = name;
        Account = account;
        Password = password;
        Email = email;
        Avatar = avatar;
        Role = role;
        VerifyAccoun();
        VerifyEmail();
        VerifyPassword();
    }

    public string Name { get; set; }

    public string Account { get;  set; }

    public string Password { get;  set; }

    public string Email { get;  set; }

    public string? Avatar { get; set; }

    public string Role { get; set; }

    public void VerifyAccoun()
    {
        if (Account.IsNullOrEmpty())
        {
            throw new UserFriendlyException("账号不能为空");
        }

        if (Account.Length < 5)
        {
            throw new UserFriendlyException("账号长度不能小于5");
        }
    }

    /// <summary>
    /// 修改密码
    /// </summary>
    /// <param name="password"></param>
    /// <exception cref="UserFriendlyException"></exception>
    public void VerifyPassword()
    {
        if (Password.IsNullOrEmpty())
        {
            throw new UserFriendlyException("密码不能为空");
        }

        if (Password.Length < 5)
        {
            throw new UserFriendlyException("密码长度不能小于5");
        }
    }

    public void VerifyEmail()
    {
        if (Email.IsNullOrEmpty())
        {
            throw new UserFriendlyException("邮箱不能为空");
        }

        if (!Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
        {
            throw new UserFriendlyException("邮箱格式错误");
        }
    }
}
