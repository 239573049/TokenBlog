using System.Net;
using System.Net.Http.Json;
using Blog.Component.Pages.Module;

namespace Blog;

public class ChatGptService : IChatGptService
{
    private readonly HttpClient _httpClient;

    private const string Prefix = "/api/app/chat-gpt";

    public ChatGptService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> PostResponse(PostResponseInput input)
    {
        var responseMessage = await _httpClient.PostAsJsonAsync(Prefix + "/response", input);
        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(message: (await responseMessage.Content.ReadFromJsonAsync<BusinessErrorDto>())?.error
                .message);
        }

        if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
        {
            throw new UnauthorizedAccessException();
        }
        
        return await responseMessage.Content.ReadAsStringAsync();
    }

    public async Task<List<ChatGptDto>> GetListAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<ChatGptDto>>(Prefix);
    }
}