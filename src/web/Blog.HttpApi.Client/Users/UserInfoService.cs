using Blog.Users;
using System.Net.Http.Json;

namespace Blog;

public class UserInfoService : IUserInfoService
{
    private readonly HttpClient _httpClient;

    private const string Prefix = "/api/app/user-info";

    public UserInfoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<UserInfoDto> GetProfileAsync()
    {
        var user = await _httpClient.GetFromJsonAsync<UserInfoDto>(Prefix + "/profile");

        return user;
    }
}