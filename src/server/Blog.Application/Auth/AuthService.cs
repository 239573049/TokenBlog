using Blog.Blog;
using Blog.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Security.Claims;

namespace Blog.Auth;

public class AuthService : ApplicationService, IAuthService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly GiteeAuthOptions _giteeOptions;
    private readonly JWTOptions _jwtOptions;
    private readonly IRepository<UserInfo> _userInfoRepository;

    public AuthService(IHttpClientFactory httpClientFactory, IOptions<GiteeAuthOptions> giteeOptions,
        IOptions<JWTOptions> jwtOptions, IRepository<UserInfo> userInfoRepository)
    {
        _httpClientFactory = httpClientFactory;
        _userInfoRepository = userInfoRepository;
        _jwtOptions = jwtOptions.Value;
        _giteeOptions = giteeOptions.Value;
    }

    /// <inheritdoc />
    public async Task<string> GiteeAuthAsync(string code, string state)
    {
        var http = _httpClientFactory.CreateClient("gitee");

        var clientSecret = Environment.GetEnvironmentVariable("ClientSecret");

        if (clientSecret.IsNullOrEmpty())
        {
            clientSecret = _giteeOptions.ClientSecret;
        }

        var uri = $"https://gitee.com/oauth/token?grant_type=authorization_code&client_id=" + _giteeOptions.ClientId
                                                                            + "&client_secret=" +
                                                                            clientSecret
                                                                            + "&redirect_uri=" + _giteeOptions.Callback
                                                                            + "&code=" + code;

        http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        AccessTokenModel data = null;
        try
        {
            var message = await http.PostAsync(uri,null);
            data = await message.Content.ReadFromJsonAsync<AccessTokenModel>();
            if (data == null || data.AccessToken.IsNullOrEmpty())
            {
                Console.WriteLine(await message.Content.ReadAsStringAsync());
                throw new BusinessException(message: "获取Gitee token失败");
            }
        }
        catch (Exception e)
        {
            throw new BusinessException(message: "获取Gitee token失败");
        }

        http = _httpClientFactory.CreateClient("GiteeAuth");
        http.DefaultRequestHeaders.Add("User-Agent",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36 Edg/110.0.1587.41");
        var info = await http.GetFromJsonAsync<GiteeUserInfo>($"https://gitee.com/api/v5/user?access_token={data.AccessToken}");

        var userInfo = await _userInfoRepository.FirstOrDefaultAsync(x => x.GiteeId == info!.id.ToString());
        if (userInfo == null)
        {
            userInfo = new UserInfo(Guid.NewGuid(), info.id.ToString(), info.avatar_url, info.name,
                info.html_url);

            // 新用户赠送额度
            userInfo.ChatGptNumber = 100;
            await _userInfoRepository.InsertAsync(userInfo);
        }
        else
        {
            userInfo.Avatar = info.avatar_url;
            userInfo.Name = info.name;
            userInfo.GiteeUrl = info.html_url;
            await _userInfoRepository.UpdateAsync(userInfo);
        }

        // 设置角色
        var roles = new List<Claim>
        {
            new(ClaimsIdentity.DefaultRoleClaimType, "User"),
            // 设置用户信息
            new(ClaimsIdentity.DefaultIssuer, JsonSerializer.Serialize(userInfo)),
            new(AbpClaimTypes.UserId, userInfo.Id.ToString())
        };

        var keyBytes = Encoding.UTF8.GetBytes(_jwtOptions.SecretKey!);
        var cred = new SigningCredentials(new SymmetricSecurityKey(keyBytes),
            SecurityAlgorithms.HmacSha256);

        var jwtSecurityToken = new JwtSecurityToken(
            _jwtOptions.Issuer, // 签发者
            _jwtOptions.Audience, // 接收者
            roles, // payload
            expires: DateTime.Now.AddMinutes(_jwtOptions.ExpireMinutes), // 过期时间
            signingCredentials: cred); // 令牌

        return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
    }
}