using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blog.Component.Shared;

public partial class Header
{
    [Parameter]
    [SupplyParameterFromQuery]
    public string? Search { get; set; }

    private async Task Login()
    {
        var authorize_uri = "https://github.com/login/oauth/authorize";
        var client_id = "8771a2c32e83bfd7c38f";
        var redirect_url = "http://localhost:5095/login";
        await JsRuntime.InvokeVoidAsync("location.replace", $"{authorize_uri}?client_id={client_id}&redirect_url={redirect_url}");
    }
}