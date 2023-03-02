using BlazorComponent;
using Blog.Blog.Dto;
using Blog.Dto;
using Semi.Design.Blazor;

namespace Blog.Component;

public partial class Compose
{
    private readonly CreateArticlesInput _input = new();

    private object Options;

    private SMonacoEditor _monacoEditor;

    private string filePage;

    private StringNumber Tab;

    public List<TagDto> TagDtos { get; set; } = new();

    protected override void OnInitialized()
    {
        Options = new
        {
            value = "", // 初始代码
            language = "markdown", // 语法支持语言
            automaticLayout = true, //自动适应父容器大小
            theme = "vs-dark" // monaco主题 
        };

        base.OnInitialized();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            TagDtos = await TagService.GetListAsync();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task CreateAsync()
    {
        _input.Content = await _monacoEditor.GetValue();
        await ArticleService.CreateAsync(_input);
        await PopupService.ToastSuccessAsync("发布成功");
        await Task.Delay(1000);
        Back();
    }

    private void Back()
    {
        NavigationManager.NavigateTo("/");
    }
}