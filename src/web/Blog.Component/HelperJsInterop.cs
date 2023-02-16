using Blog.Shared;
using Microsoft.JSInterop;

namespace Blog.Component;
// This class provides an example of how JavaScript functionality can be wrapped
// in a .NET class for easy consumption. The associated JavaScript module is
// loaded on demand when first needed.
//
// This class can be registered as scoped DI service and then injected into Blazor
// components for use.

public class HelperJsInterop : ITokenService, IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public HelperJsInterop(IJSRuntime jsRuntime)
    {
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/Blog.Component/helperJsInterop.js").AsTask());
    }

    public async ValueTask<string> ByteToUrl(byte[] blob)
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("byteToUrl", blob);
    }

    public async ValueTask<string> RevokeUrl(string url)
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("revokeUrl", url);
    }

    public async ValueTask ClickDom(string id)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("clickDom", id);
    }

    public async ValueTask<string> GetTokenAsync()
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("getToken");
    }

    public async ValueTask SetToken(string value)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("setToken", value);
    }

    public async ValueTask DisposeAsync()
    {
        if (moduleTask.IsValueCreated)
        {
            var module = await moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}