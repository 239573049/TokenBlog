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
        // 通过密码账号获取用户信息
        var info = await _userInfoRepository.FindAsync(x => x.Account == query.account && x.Password == query.password);
 
        // 如果用户不存在，抛出异常
        if (info == null)
        {
            throw new UserFriendlyException("账号或密码错误");
        }

        // 生成token
        var claimsIdentity = JwtHelper.GetClaimsIdentity(info);

        var token = JwtHelper.GeneratorAccessToken(claimsIdentity, _jwtOptions);

        query.Result = token;
    }

    [EventHandler]
    public async Task GetUser(GetUserQuery query)
    {
        // 通过token获取用户信息
        var token = _contextAccessor.HttpContext?.Request.Headers.Authorization.ToString();
        
        // 如果token为空，抛出异常
        var json = await redis.GetAsync(token);
        if (json.IsNullOrEmpty())
        {
            throw new UnauthorizedAccessException();
        }

        query.Result = JsonSerializer.Deserialize<UserInfo>(json);
    }
}
