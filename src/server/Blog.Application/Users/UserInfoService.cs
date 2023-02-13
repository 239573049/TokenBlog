using Blog.Blog;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Blog.Users;

[Authorize]
public class UserInfoService : ApplicationService, IUserInfoService
{
    private readonly IRepository<UserInfo> _userInfoRepository;

    public UserInfoService(IRepository<UserInfo> userInfoRepository)
    {
        _userInfoRepository = userInfoRepository;
    }

    public async Task<UserInfoDto> GetProfileAsync()
    {
        var userInfo = await _userInfoRepository.FirstOrDefaultAsync(x => x.Id == CurrentUser.Id);
        
        return ObjectMapper.Map<UserInfo, UserInfoDto>(userInfo);
    }
}