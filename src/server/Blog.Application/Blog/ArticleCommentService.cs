using Blog.Blog.Dto;
using Volo.Abp.Application.Services;

namespace Blog.Blog;

public class ArticleCommentService : ApplicationService, IArticleCommentService
{
    private readonly IArticleCommentRepository _articleCommentRepository;

    public ArticleCommentService(IArticleCommentRepository articleCommentRepository)
    {
        _articleCommentRepository = articleCommentRepository;
    }

    /// <inheritdoc />
    public async Task CreateAsync(CreateArticleCommentInput input)
    {
        await _articleCommentRepository.InsertAsync(new ArticleComment
        {
            ArticleId = input.ArticleId,
            UserId = CurrentUser.Id.Value,
            
            Content = input.Content,
            CreationTime = input.CreationTime,
            ParentId = input.ParentId
        });
        
    }

    /// <inheritdoc />
    public async Task<List<GetArticleCommentDto>> GetListAsync(GetArticleCommentInput input)
    {
        var data = await _articleCommentRepository.GetListAsync(input.ArticleId,input.ParentId);

        return ObjectMapper.Map<List<ArticleCommentView>,List<GetArticleCommentDto>>(data);
    }

    /// <inheritdoc />
    public async Task DeleteAsync(Guid id)
    {
        await _articleCommentRepository.DeleteAsync(x=>x.Id == id && x.UserId == CurrentUser.Id.Value);
    }
}