using Blog.Blog;
using Blog.Blog.Dto;
using System.Net.Http.Json;

namespace Blog.HttpClient;

public class TagService : ITagService
{
    private readonly IHttpClientFactory _httpClientFactory;

    private const string Prefix = "/api/app/tag";

    public TagService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<TagDto>> GetListAsync()
    {
        var http = _httpClientFactory.CreateClient(string.Empty);

        return await http.GetFromJsonAsync<List<TagDto>>(Prefix);
    }

    public Task CreateAsync(TagDto input)
    {
        throw new NotImplementedException();
    }
}