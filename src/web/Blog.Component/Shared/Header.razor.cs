using Blog.Users;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blog.Component.Shared;

public partial class Header
{
    [Parameter] [SupplyParameterFromQuery] public string? Search { get; set; }

    public UserInfoDto UserInfoDto { get; set; }

    private void OnSearch()
    {
        _ = KeyLoadEventBus.PushAsync(EventBusConstant.ArticleListSearch, Search);
    }

    private async Task Login()
    {
        await AuthService.GitHub();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await LoadUserInfo();
            KeyLoadEventBus.Subscription(EventBusName.GetProfile, async (_) => { await LoadUserInfo(); });
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private void Compose()
    {
        NavigationManager.NavigateTo("/compose");
    }

    private async Task LoadUserInfo()
    {
        var token = await HelperJsInterop.GetTokenAsync();
        if (!string.IsNullOrEmpty(token) && UserInfoDto == null)
        {
            try
            {
                HttpClient.DefaultRequestHeaders.Add("Authorization", token);
                UserInfoDto = await UserInfoService.GetProfileAsync();
                _ = InvokeAsync(StateHasChanged);
            }
            catch
            {
            }
        }
    }
}