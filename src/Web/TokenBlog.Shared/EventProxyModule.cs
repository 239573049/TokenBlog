using Microsoft.JSInterop;

namespace TokenBlog.Shared;

public class EventProxyModule : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public EventProxyModule(IJSRuntime jsRuntime)
    {
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/TokenBlog.Shared/event-proxy.js").AsTask());
    }

    public async ValueTask<string> AddOnmouseenter<T>(string id, DotNetObjectReference<T> dotNet, string methode)
        where T : class
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("addOnmouseenter", id, dotNet, methode);
    }
    
    public async ValueTask<string> AddOnmouseleave<T>(string id, DotNetObjectReference<T> dotNet, string methode)
        where T : class
    {
        var module = await moduleTask.Value;
        return await module.InvokeAsync<string>("addOnmouseleave", id, dotNet, methode);
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