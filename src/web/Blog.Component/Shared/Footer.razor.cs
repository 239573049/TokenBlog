using System.Text.Json;
using Blog.Blog.Dto;
using Blog.Settings;
using Microsoft.JSInterop;

namespace Blog.Component;

public partial class Footer
{
    private const string Wosperry = "https://wosperry.com/";

    private const string Dotnet9 = "https://dotnet9.com/";

    private const string Github = "https://github.com/239573049";

    private const string BiliBili = "https://space.bilibili.com/242357983";

    private List<ExternalLinkDto>? ExternalLinks { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        var value = await SettingService.GetAsync(BlogSettings.BlogInfo.ExternalLinks);
        ExternalLinks = JsonSerializer.Deserialize<List<ExternalLinkDto>>(value);
        await base.OnInitializedAsync();
    }

    private async Task GoTo(string url)
    {
        // 调用js跳转到指定url
        await JsRuntime.InvokeVoidAsync("window.open", url, "_blank");
    }
}