using Blog.Blog.Dto;
using Microsoft.AspNetCore.Components;
using Volo.Abp.Application.Dtos;

namespace Blog.Component;

public partial class TopSearch
{

    [Parameter]
    [CascadingParameter(Name = nameof(TagId))]
    public Guid? TagId { get; set; }

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

        await base.OnInitializedAsync();
    }

    private async Task GetListAsync()
    {
        ArticlesDto = await ArticleService.GetListAsync(new GetArticlesInput()
        {
            Search = Search,
            TagId = TagId
        });
    }
}