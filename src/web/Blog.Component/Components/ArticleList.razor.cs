using Blog.Blog.Dto;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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

    private GetArticlesInput _input = new();

    private async Task GetListAsync()
    {
        _input.Search = Search;
        _input.TagId = TagId;
        ArticlesDto = await ArticleService.GetListAsync(_input);

        _ = InvokeAsync(StateHasChanged);
    }

    private async Task GoTo(string url)
    {
        // 调用js跳转到指定url
        await JsRuntime.InvokeVoidAsync("window.open", url, "_blank");
    }
    private void OpenArticle(ArticlesDto dto)
    {
        NavigationManager.NavigateTo("/show-article/" + dto.Id);
    }
}