using System.Net.Http.Json;
using Blog.Blog;
using Blog.Blog.Dto;

namespace Blog.HttpClient;

public class ArticleCommentService : IArticleCommentService
{
    private readonly IHttpClientFactory _httpClientFactory;

    private const string Prefix = "/api/app/article-comment";

    public ArticleCommentService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task CreateAsync(CreateArticleCommentInput input)
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        await http.PostAsJsonAsync(Prefix, input);
    }

    public async Task<List<GetArticleCommentDto>> GetListAsync(GetArticleCommentInput input)
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        return await http.GetFromJsonAsync<List<GetArticleCommentDto>>(Prefix + input.ToUriParam());
    }

    public async Task DeleteAsync(Guid id)
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        await http.DeleteAsync(Prefix + "/" + id);
    }
}