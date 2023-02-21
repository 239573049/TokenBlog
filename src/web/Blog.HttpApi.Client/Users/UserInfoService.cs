using System.Net;
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
        var message = await _httpClient.GetAsync(Prefix + "/profile");

        if (message.StatusCode == HttpStatusCode.Unauthorized)
        {
            throw new UnauthorizedAccessException();
        }
        
        return await message.Content.ReadFromJsonAsync<UserInfoDto>();
    }
}