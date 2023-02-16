using BlazorComponent;
using Blog.Blog.Dto;
using Microsoft.AspNetCore.Components.Forms;
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

    public IBrowserFile? browserFile { get; set; }

    public IBrowserFile? BrowserFile
    {
        get => browserFile;
        set
        {
            browserFile = value;
            LoadFile();
        }
    }

    private async Task LoadFile()
    {
        await using var memoryStream = new MemoryStream();
        await browserFile.OpenReadStream(browserFile.Size).CopyToAsync(memoryStream);
        filePage = await HelperJsInterop.ByteToUrl(memoryStream.ToArray());
        _ = InvokeAsync(StateHasChanged);
    }

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
        if (BrowserFile == null)
        {
            await ArticleService.CreateAsync(_input);
            await PopupService.ToastSuccessAsync("发布成功");
            return;
        }

        var result =
            await FileSystemService.Uploading(BrowserFile.OpenReadStream(BrowserFile.Size),
                BrowserFile.Name);

        if (!string.IsNullOrEmpty(result))
        {
            _input.PictorialView = result;
            await ArticleService.CreateAsync(_input);
            await PopupService.ToastSuccessAsync("发布成功");
        }
        else
        {
            await PopupService.ToastErrorAsync("上传图片的时候似乎出现了问题");
        }
    }

    private void Back()
    {
        NavigationManager.NavigateTo("/");
    }
}