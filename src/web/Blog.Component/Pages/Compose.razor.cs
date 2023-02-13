using Blog.Blog.Dto;

namespace Blog.Component;

public partial class Compose
{
    private readonly CreateArticlesInput _input = new ();
    
    private Dictionary<string, object> _options = new Dictionary<string, object>();

    protected override void OnInitialized()
    {
        _options.Add("mode","ir");
        _options.Add("counter", new
        {
            enable = true,
            type = "type"
        });
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