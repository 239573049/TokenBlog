using Blog.Blog.Dto;
using Microsoft.AspNetCore.Components;
using Volo.Abp.Application.Dtos;

namespace Blog.Component;

public partial class ArticleList
{
    private Guid? tagId;

    [Parameter]
    [CascadingParameter(Name = nameof(TagId))]
    public Guid? TagId
    {
        get => tagId;
        set
        {
            tagId = value;
            _ = GetListAsync();
        }
    }

    /// <summary>
    /// 搜索条件
    /// </summary>
    [Parameter]
    [CascadingParameter(Name = nameof(Search))]
    public string? Search { get; set; }

    public PagedResultDto<ArticlesDto>? ArticlesDto { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetListAsync();
        KeyLoadEventBus.Subscription(EventBusConstant.ArticleListSearch, async (value) =>
        {
            Search = (string?)value;
            await GetListAsync();
        });
        await base.OnInitializedAsync();
    }

    private async Task GetListAsync()
    {
        ArticlesDto = await ArticleService.GetListAsync(new GetArticlesInput()
        {
            Search = Search,
            TagId = TagId
        });

        _ = InvokeAsync(StateHasChanged);
    }

    private void OpenArticle(ArticlesDto dto)
    {
        NavigationManager.NavigateTo("/show-article/" + dto.Id);
    }
}