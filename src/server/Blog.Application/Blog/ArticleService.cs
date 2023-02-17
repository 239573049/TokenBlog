using Blog.Blog.Dto;
using Blog.Dto;
using Blog.ETO;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Local;
using Volo.Abp.Users;

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
        var data = await _articlesRepository.GetListAsync(input.TagId, input.Search, null, input.SkipCount,
            input.MaxResultCount);

        var count = await _articlesRepository.GetCountAsync(input.TagId, input.Search, null);

        var dto = ObjectMapper.Map<List<ArticleView>, List<ArticlesDto>>(data);

        return new PagedResultDto<ArticlesDto>(count, dto);
    }

    public async Task CreateAsync(CreateArticlesInput input)
    {
        var article = new Article(Guid.NewGuid())
        {
            Title = input.Title,
            Description = input.Description,
            UserId = CurrentUser.Id!.Value,
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

    /// <inheritdoc />
    [Authorize]
    public async Task<PagedResultDto<ArticleUserInfoDto>> GetArticleUserInfoAsync(GetArticleUserInfoInput input)
    {
        var data = await _articlesRepository.GetListAsync(null, input.Search, CurrentUser.GetId(), input.SkipCount,
            input.MaxResultCount);

        var count = await _articlesRepository.GetCountAsync(null, input.Search, CurrentUser.GetId());

        var dto = ObjectMapper.Map<List<ArticleView>, List<ArticleUserInfoDto>>(data);

        return new PagedResultDto<ArticleUserInfoDto>(count, dto);
    }

    /// <inheritdoc />
    public async Task DeleteUserInfoAsync(Guid id)
    {
        await _articlesRepository.DeleteAsync(x => x.Id == id && x.UserId == CurrentUser.GetId());
    }
}