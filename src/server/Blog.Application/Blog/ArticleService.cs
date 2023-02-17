using Blog.Blog.Dto;
using Blog.Dto;
using Blog.ETO;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.EventBus.Local;

namespace Blog.Blog;

public class ArticleService : ApplicationService, IArticleService
{
    private readonly IArticlesRepository _articlesRepository;
    private readonly ILocalEventBus _localEventBus;

    public ArticleService(IArticlesRepository articlesRepository, ILocalEventBus localEventBus)
    {
        _articlesRepository = articlesRepository;
        _localEventBus = localEventBus;
    }

    public async Task<PagedResultDto<ArticlesDto>> GetListAsync(GetArticlesInput input)
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

        await _localEventBus.PublishAsync(new GetArticleEto(id));

        return ObjectMapper.Map<ArticleView, GetArticlesDto>(data);
    }

    /// <inheritdoc />
    public async Task<List<ArticlesDto>> GetTopSearch()
    {
        var data = await _articlesRepository.GetTopSearchAsync();

        return ObjectMapper.Map<List<Article>, List<ArticlesDto>>(data);
    }
}