using System.Net.Http.Json;
using Blog.Users;

namespace Blog;

public class UserInfoService : IUserInfoService
{
    private readonly System.Net.Http.HttpClient _httpClient;

    private const string Prefix = "/api/app/user-info";

    public UserInfoService(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<UserInfoDto> GetProfileAsync()
    {
        var user = await _httpClient.GetFromJsonAsync<UserInfoDto>(Prefix + "/profile");

        return user;
    }
}