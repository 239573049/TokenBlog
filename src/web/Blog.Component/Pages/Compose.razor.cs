using BlazorComponent;
using Blog.Blog.Dto;

namespace Blog.Component;

public partial class Compose
{
    private readonly CreateArticlesInput _input = new();

    private Dictionary<string, object> _options = new();

    private StringNumber Tab;  
    
    protected override void OnInitialized()
    {
        _options.Add("toolbar",new List<string>(){"emoji", "br", "bold", "|", "line"});
        _options.Add("mode", "ir");
        base.OnInitialized();
    }

    private async Task CreateAsync()
    {
        await ArticleService.CreateAsync(_input);
    }

    private void Back()
    {
        NavigationManager.NavigateTo("/");
    }
}