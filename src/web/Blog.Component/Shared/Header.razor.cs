using Blog.Users;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace Blog.Component.Shared;

public partial class Header
{
    [Parameter]
    [SupplyParameterFromQuery]
    public string? Search { get; set; }

    public UserInfoDto UserInfoDto { get; set; }

    private async Task Login()
    {
        var authorize_uri = "https://github.com/login/oauth/authorize";
        var client_id = "8771a2c32e83bfd7c38f";
        var redirect_url = "http://localhost:5095/login";
        await JsRuntime.InvokeVoidAsync("location.replace",
            $"{authorize_uri}?client_id={client_id}&redirect_url={redirect_url}");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await LoadUserInfo();
            KeyLoadEventBus.Subscription(EventBusName.GetProfile, async (value) => { await LoadUserInfo(); });
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private void Compose()
    {
        NavigationManager.NavigateTo("/compose");
    }

    private async Task LoadUserInfo()
    {
        if (!string.IsNullOrEmpty(BlogHttpApiClientExtension.Token) && UserInfoDto == null)
        {
            try
            {
                UserInfoDto = await UserInfoService.GetProfileAsync();
                _ = InvokeAsync(StateHasChanged);
            }
            catch
            {
                BlogHttpApiClientExtension.SetToken(string.Empty);
            }
        }
    }
}