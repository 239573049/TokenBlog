using Blog.Contracts.Auth;
using Blog.Service.Application.Users.Querues;
using Blog.Service.Domain.Users.Aggregates;
using Blog.Service.Domain.Users.Repositories;
using Blog.Service.Infrastructure.Helpers;
using FreeRedis;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace Blog.Service.Application.Users;

public class UserQueryHandler
{
    private readonly IUserInfoRepository _userInfoRepository;
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly RedisClient redis;
    private readonly JwtOptions _jwtOptions;

    public UserQueryHandler(IUserInfoRepository userInfoRepository, IHttpContextAccessor contextAccessor, RedisClient redis, IOptions<JwtOptions> jwtOptions)
    {
        _userInfoRepository = userInfoRepository;
        _contextAccessor = contextAccessor;
        this.redis = redis;
        _jwtOptions = jwtOptions.Value;
    }

    [EventHandler]
    public async Task GetUserInfo(GetUserInfoQuery query)
    {
        var info = await _userInfoRepository.FindAsync(x => x.Account == query.account && x.Password == query.password);
        if (info == null)
        {
            throw new UserFriendlyException("账号或密码错误");
        }

        var claimsIdentity = JwtHelper.GetClaimsIdentity(info);

        var token = JwtHelper.GeneratorAccessToken(claimsIdentity, _jwtOptions);

        query.Result = token;
    }

    [EventHandler]
    public async Task GetUser(GetUserQuery query)
    {
        var token = _contextAccessor.HttpContext?.Request.Headers.Authorization.ToString();
        var json = await redis.GetAsync(token);
        if (json.IsNullOrEmpty())
        {
            throw new UnauthorizedAccessException();
        }

        query.Result = JsonSerializer.Deserialize<UserInfo>(json);
    }
}
