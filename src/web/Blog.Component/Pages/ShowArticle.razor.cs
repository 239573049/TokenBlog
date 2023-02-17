using Blog.Dto;
using Microsoft.AspNetCore.Components;

namespace Blog.Component;

public partial class ShowArticle
{
    [Parameter] public Guid Id { get; set; }

    public GetArticlesDto ArticlesDto { get; set; }

    public bool ShowComment { get; set; } = true;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var token = await HelperJsInterop.GetTokenAsync();
            ShowComment = !string.IsNullOrEmpty(token);
            if (Id == Guid.Empty)
            {
                NavigationManager.NavigateTo("/");
                return;
            }
            await GetArticle();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    private void GetBack()
    {
        NavigationManager.NavigateTo("/");
    }

    private async Task GetArticle()
    {
        ArticlesDto = await ArticleService.GetAsync(Id);
        StateHasChanged();
    }
}