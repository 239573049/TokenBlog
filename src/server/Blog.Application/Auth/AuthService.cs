using Blog.Blog;
using Blog.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
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
    private readonly GitHubAuthOptions _gitHubOptions;
    private readonly JWTOptions _jwtOptions;
    private readonly IRepository<UserInfo> _userInfoRepository;

    public AuthService(IHttpClientFactory httpClientFactory, IOptions<GitHubAuthOptions> gitHubOptions,
        IOptions<JWTOptions> jwtOptions, IRepository<UserInfo> userInfoRepository)
    {
        _httpClientFactory = httpClientFactory;
        _userInfoRepository = userInfoRepository;
        _jwtOptions = jwtOptions.Value;
        _gitHubOptions = gitHubOptions.Value;
    }

    /// <inheritdoc />
    public async Task<string> GitHubAuthAsync(string code, string state)
    {
        var http = _httpClientFactory.CreateClient("github");

        var uri = $"https://github.com/login/oauth/access_token?client_id=" + _gitHubOptions.ClientId
                                                                            + "&client_secret=" +
                                                                            _gitHubOptions.ClientSecret
                                                                            + "&redirect_uri=" + _gitHubOptions.Callback
                                                                            + "&code=" + code
                                                                            + "&state=" + state;

        http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        AccessTokenModel data = null;
        try
        {
            data = await http.GetFromJsonAsync<AccessTokenModel>(uri);
            if (data == null || data.AccessToken.IsNullOrEmpty())
            {
                throw new BusinessException(message: "获取GitHub token失败");
            }

        }
        catch (Exception e)
        {
            throw new BusinessException(message: "获取GitHub token失败");
        }

        http = _httpClientFactory.CreateClient("GitHubAuth");
        http.DefaultRequestHeaders.Add("Authorization", "Bearer " + data.AccessToken);
        http.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36 Edg/110.0.1587.41");
        var info = await http.GetFromJsonAsync<GitHubUserInfo>($"https://api.github.com/user");

        var userInfo = await _userInfoRepository.FirstOrDefaultAsync(x => x.GitHubId == info!.id.ToString());
        if (userInfo == null)
        {
            userInfo = new UserInfo(Guid.NewGuid(), info.id.ToString(), info.avatar_url, info.name,
                info.url);
            await _userInfoRepository.InsertAsync(userInfo);
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