using System.Net.Http.Headers;
using System.Net.Http.Json;
using Blog.Options;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace Blog.Auth;

public class AuthService : ApplicationService, IAuthService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly GitHubAuthOptions _gitHubOptions;

    public AuthService(IHttpClientFactory httpClientFactory, IOptions<GitHubAuthOptions> gitHubOptions)
    {
        _httpClientFactory = httpClientFactory;
        _gitHubOptions = gitHubOptions.Value;
    }

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

        var data = await http.GetFromJsonAsync<AccessTokenModel>(uri);

        if (data == null || data.AccessToken.IsNullOrEmpty())
        {
            throw new BusinessException(message: "获取GitHub token失败");
        }

        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(data!.AccessToken);
        
        var info = await http.GetFromJsonAsync<GitHubUserInfo>("https://api.github.com/user?access_token=" + data?.AccessToken);
        
        return "";
    }
}