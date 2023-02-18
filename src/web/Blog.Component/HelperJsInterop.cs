using Microsoft.JSInterop;
using System.Text.Json;

namespace Blog.Component;
// This class provides an example of how JavaScript functionality can be wrapped
// in a .NET class for easy consumption. The associated JavaScript module is
// loaded on demand when first needed.
//
// This class can be registered as scoped DI service and then injected into Blazor
// components for use.

public class HelperJsInterop : IAsyncDisposable
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

    public async ValueTask SetLocalStorage(string key, string value)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("setLocalStorage", key, value);
    }

    public async ValueTask<string> GetLocalStorage(string key)
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("getLocalStorage", key);
    }

    public async ValueTask SetLocalStorage<T>(string key, T value) where T : class
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("setLocalStorage", key, JsonSerializer.Serialize(value));
    }

    public async ValueTask<T> GetLocalStorage<T>(string key) where T : class
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<T>("getLocalStorage", key);
    }

    public async ValueTask ScrollHeight(string id)
    {
        var module = await moduleTask.Value;
        await module.InvokeVoidAsync("scrollHeight", id);
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