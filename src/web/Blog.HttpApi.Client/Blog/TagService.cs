using Blog.Blog;
using Blog.Blog.Dto;
using System.Net.Http.Json;

namespace Blog;

public class TagService : ITagService
{
    private readonly System.Net.Http.HttpClient _httpClient;

    private const string Prefix = "/api/app/tag";

    public TagService(System.Net.Http.HttpClient httpClient)
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