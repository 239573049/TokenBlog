using Blog.Blog;
using Blog.Blog.Dto;
using System.Net.Http.Json;
using Volo.Abp.Application.Dtos;

namespace Blog.HttpClient;

public class ArticleService : IArticleService
{
    private readonly IHttpClientFactory _httpClientFactory;

    private const string Prefix = "/api/app/article";

    public ArticleService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<PagedResultDto<ArticlesDto>?> GetListAsync(GetArticlesInput input)
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        return await http.GetFromJsonAsync<PagedResultDto<ArticlesDto>>(Prefix + input.ToUriParam());
    }

    public async Task CreateAsync(CreateArticlesInput input)
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        await http.PostAsJsonAsync(Prefix, input);
    }

    public async Task<GetArticlesDto> GetAsync(Guid id)
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        return await http.GetFromJsonAsync<GetArticlesDto>(Prefix + "/" + id);
    }
}