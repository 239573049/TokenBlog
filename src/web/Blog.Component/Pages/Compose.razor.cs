using BlazorComponent;
using Blog.Blog.Dto;
using Microsoft.AspNetCore.Components.Forms;

namespace Blog.Component;

public partial class Compose
{
    private readonly CreateArticlesInput _input = new();

    private Dictionary<string, object> _options = new();

    private string filePage;

    private StringNumber Tab;

    public List<TagDto> TagDtos { get; set; } = new();

    public IBrowserFile browserFile { get; set; }

    public IBrowserFile BrowserFile
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
        filePage = await HelperJsInterop.ByteToUrl(
            await browserFile.OpenReadStream(browserFile.Size).GetAllBytesAsync());
        _ = InvokeAsync(StateHasChanged);
    }

    protected override void OnInitialized()
    {
        _options.Add("toolbar", new List<string>() { "emoji", "br", "bold", "|", "line" });
        _options.Add("mode", "ir");
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
        var result =
            await FileSystemService.Uploading(await BrowserFile.OpenReadStream(BrowserFile.Size).GetAllBytesAsync(),
                BrowserFile.Name);
        if (!string.IsNullOrEmpty(result))
        {
            _input.PictorialView = result;
            await ArticleService.CreateAsync(_input);
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