using Microsoft.JSInterop;

namespace Blog.Component;

public class AuthService
{
    private readonly IJSRuntime JsRuntime;

    public AuthService(IJSRuntime jsRuntime)
    {
        JsRuntime = jsRuntime;
    }

    public async Task GitHub()
    {
        var authorize_uri = "https://github.com/login/oauth/authorize";
        var client_id = "19c959e3a2f19a495905";
#if DEBUG
        var redirect_url = "https://blog.tokengo.top/login";
#else
        var redirect_url = "http://localhost:5095/login";
#endif
        await JsRuntime.InvokeVoidAsync("location.replace",
            $"{authorize_uri}?client_id={client_id}&redirect_url={redirect_url}");
    }
}