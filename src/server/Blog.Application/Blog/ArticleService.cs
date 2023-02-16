using Blog.Blog.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Blog.Blog;

public class ArticleService : ApplicationService, IArticleService
{
    private readonly IArticlesRepository _articlesRepository;

    public ArticleService(IArticlesRepository articlesRepository)
    {
        _articlesRepository = articlesRepository;
    }

    public async Task<PagedResultDto<ArticlesDto>?> GetListAsync(GetArticlesInput input)
    {
        var data = await _articlesRepository.GetListAsync(input.TagId, input.Search, input.SkipCount,
            input.MaxResultCount);

        var count = await _articlesRepository.GetCountAsync(input.TagId, input.Search);

        var dto = ObjectMapper.Map<List<Article>, List<ArticlesDto>>(data);

        return new PagedResultDto<ArticlesDto>(count, dto);
    }

    public async Task CreateAsync(CreateArticlesInput input)
    {
        var article = new Article(Guid.NewGuid())
        {
            Title = input.Title,
            Description = input.Description,
            UserId = CurrentUser.Id!.Value,
            PictorialView = input.PictorialView,
            Content = input.Content,
            TagId = input.TagId
        };

        await _articlesRepository.InsertAsync(article);
    }

    public async Task<GetArticlesDto> GetAsync(Guid id)
    {
        var data = await _articlesRepository.GetAsync(id);

        return ObjectMapper.Map<ArticleView,GetArticlesDto>(data);
    }
}