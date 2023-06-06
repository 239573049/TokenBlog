using Blog.Service.Domain.Bloggers.Views;

namespace Blog.Service.Domain.Bloggers.Repositories;

public class BloggerDomainService : IScopedDependency
{
    private readonly IArticleRepository _articleRepository;

    public BloggerDomainService(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    public async Task<BloggerKanban> GetBloggerKanbanAsync(Guid userId)
    {
        
        
        return new BloggerKanban();
    } 
}