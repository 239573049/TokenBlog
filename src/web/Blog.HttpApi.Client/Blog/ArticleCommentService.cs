using Blog.Blog;
using Blog.Blog.Dto;
using System.Net.Http.Json;
using Blog.Dto;

namespace Blog;

public class ArticleCommentService : IArticleCommentService
{
    private readonly HttpClient _httpClient;

    private const string Prefix = "/api/app/article-comment";

    public ArticleCommentService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task CreateAsync(CreateArticleCommentInput input)
    {
        await _httpClient.PostAsJsonAsync(Prefix, input);
    }

    public async Task<List<GetArticleCommentDto>> GetListAsync(GetArticleCommentInput input)
    {
        return await _httpClient.GetFromJsonAsync<List<GetArticleCommentDto>>(Prefix + input.ToUriParam());
    }

    public async Task DeleteAsync(Guid id)
    {
        await _httpClient.DeleteAsync(Prefix + "/" + id);
    }
}