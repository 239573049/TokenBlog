using Masa.BuildingBlocks.Ddd.Domain.Entities.Full;
using System.Text.RegularExpressions;

namespace Blog.Service.Domain.Users.Aggregates;

public class UserInfo : FullAggregateRoot<Guid, Guid?>
{
    public UserInfo(Guid id, string account, string password, string email, string? avatar, string role) : base(id)
    {
        Avatar = avatar;
        Role = role;
        UpdateAccoun(account);
        UpdatePassword(password);
        UpdateEmail(email);
    }

    public string Account { get; private set; }

    public string Password { get; private set; }

    public string Email { get; private set; }

    public string? Avatar { get; private set; }

    public string Role { get; private set; }

    public void UpdateAccoun(string accoun)
    {
        if (accoun.IsNullOrEmpty())
        {
            throw new UserFriendlyException("账号不能为空");
        }

        if (accoun.Length < 5)
        {
            throw new UserFriendlyException("账号长度不能小于5");
        }
        Account = accoun;
    }

    /// <summary>
    /// 修改密码
    /// </summary>
    /// <param name="password"></param>
    /// <exception cref="UserFriendlyException"></exception>
    public void UpdatePassword(string password)
    {
        if (password.IsNullOrEmpty())
        {
            throw new UserFriendlyException("密码不能为空");
        }

        if (password.Length < 5)
        {
            throw new UserFriendlyException("密码长度不能小于5");
        }

        Password = password;
    }

    public void UpdateEmail(string email)
    {
        if (email.IsNullOrEmpty())
        {
            throw new UserFriendlyException("邮箱不能为空");
        }
        string str = @"^[1-9][0-9]{4,}@qq.com$";
        Regex mReg = new Regex(str);

        if (!mReg.IsMatch(email))
        {
            throw new UserFriendlyException("邮箱格式错误");
        }

        Email = email;
    }
}
