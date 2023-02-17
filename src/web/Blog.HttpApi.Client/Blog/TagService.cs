using Blog.Blog;
using Blog.Blog.Dto;
using System.Net.Http.Json;
using Blog.Dto;

namespace Blog;

public class TagService : ITagService
{
    private readonly HttpClient _httpClient;

    private const string Prefix = "/api/app/tag";

    public TagService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<TagDto>> GetListAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<TagDto>>(Prefix);
    }

    public Task CreateAsync(TagDto input)
    {
        throw new NotImplementedException();
    }
}