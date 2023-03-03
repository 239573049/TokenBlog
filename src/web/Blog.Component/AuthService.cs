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
        var authorize_uri = "https://gitee.com/oauth/authorize";
#if !DEBUG
        var client_id = "9f850a9918d425f7fa5c0cb75957ae6b61282f6c7a36a28960f05b16dc697f09";
        var redirect_url = "http://server.tokengo.top:11000/login";
#else
        var client_id = "55f3dce429160a074204b93a6dc886a1d764ebb58383fb6e03c33b395aefbe34";
        var redirect_url = "https://blog.tokengo.top/login";
#endif
        await JsRuntime.InvokeVoidAsync("location.replace",
            $"{authorize_uri}?client_id={client_id}&response_type=code&redirect_uri={redirect_url}");
    }
}