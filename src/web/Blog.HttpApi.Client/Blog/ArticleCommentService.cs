using Blog.Blog;
using Blog.Blog.Dto;

namespace Blog.HttpClient;

public class ArticleCommentService : IArticleCommentService
{
    public Task CreateAsync(CreateArticleCommentInput input)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetArticleCommentDto>> GetListAsync(GetArticleCommentInput input)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}