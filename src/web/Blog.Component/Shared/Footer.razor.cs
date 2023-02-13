using System.Net.Http.Json;
using Blog.Users;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace Blog.Component.Shared;

public partial class Footer
{
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

}