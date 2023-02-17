using System.Text.Json;
using Blog.Blog.Dto;
using Microsoft.JSInterop;

namespace Blog.Component;

public partial class Home
{
    private List<CarouselDto> Carousels { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        var json = await SettingService.GetAsync(BlogSettings.BlogInfo.Carousels);
        Carousels = JsonSerializer.Deserialize<List<CarouselDto>>(json);
        await base.OnInitializedAsync();
    }
    
    private async Task GoTo(string url)
    {
        // 调用js跳转到指定url
        await JsRuntime.InvokeVoidAsync("window.open", url, "_blank");
    }
}