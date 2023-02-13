using Blog.Users;
using System.Net.Http.Json;

namespace Blog.HttpClient;

public class UserInfoService : IUserInfoService
{
    private readonly IHttpClientFactory _httpClientFactory;

    private const string Prefix = "/api/app/user-info";

    public UserInfoService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<UserInfoDto> GetProfileAsync()
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        var user = await http.GetFromJsonAsync<UserInfoDto>(Prefix + "/profile");

        return user;
    }
}