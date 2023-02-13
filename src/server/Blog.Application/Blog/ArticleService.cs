using Blog.Blog.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Blog.Blog;

public class ArticleService : ApplicationService, IArticleService
{
    private readonly IArticlesRepository _articlesRepository;
    private readonly IRepository<TagRelevanceArticle> _tagRelevanceArticleRepository;

    public ArticleService(IArticlesRepository articlesRepository, IRepository<TagRelevanceArticle> tagRelevanceArticleRepository)
    {
        _articlesRepository = articlesRepository;
        _tagRelevanceArticleRepository = tagRelevanceArticleRepository;
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
            UserId = CurrentUser.Id.Value,
            PictorialView = input.PictorialView,
            Content = input.Content,
        };

        var tagRelevance = input.TagIds?.Select(x => new TagRelevanceArticle()
        {
            TagId = x,
            ArticleId = article.Id
        });

        await _articlesRepository.InsertAsync(article);
        await _tagRelevanceArticleRepository.InsertManyAsync(tagRelevance);
    }
}