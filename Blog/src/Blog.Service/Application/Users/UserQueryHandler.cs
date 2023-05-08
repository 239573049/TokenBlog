using Blog.Service.Application.Users.Querues;
using Blog.Service.Domain.Users.Repositories;

namespace Blog.Service.Application.Users;

public class UserQueryHandler
{
    private readonly IUserInfoRepository _userInfoRepository;

    public UserQueryHandler(IUserInfoRepository userInfoRepository)
    {
        _userInfoRepository = userInfoRepository;
    }

    [EventHandler]
    public async Task GetUserInfo(GetUserInfoQuery query)
    {
        var info = await _userInfoRepository.FindAsync(x => x.Account == query.account && x.Password == query.password);
        if (info == null)
        {
            throw new UserFriendlyException("账号或密码错误");
        }
        query.Result = info;
    }
}
