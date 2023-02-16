using Blog.Blog;
using Blog.Blog.Dto;
using System.Net.Http.Json;
using Volo.Abp.Application.Dtos;

namespace Blog;

public class ArticleService : IArticleService
{
    private readonly HttpClient _httpClient;

    private const string Prefix = "/api/app/article";

    public ArticleService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PagedResultDto<ArticlesDto>?> GetListAsync(GetArticlesInput input)
    {
        return await _httpClient.GetFromJsonAsync<PagedResultDto<ArticlesDto>>(Prefix + input.ToUriParam());
    }

    public async Task CreateAsync(CreateArticlesInput input)
    {
        await _httpClient.PostAsJsonAsync(Prefix, input);
    }

    public async Task<GetArticlesDto> GetAsync(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<GetArticlesDto>(Prefix + "/" + id);
    }

    public async Task<List<ArticlesDto>> GetTopSearch()
    {
        return await _httpClient.GetFromJsonAsync<List<ArticlesDto>>(Prefix+ "/top-search");
    }
}