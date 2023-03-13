
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TokenBlog;
using TokenBlog.Shared;
using TokenBlog.Shared.Global;
using TokenBlog.WebAssembly;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, TestAuthStateProvider>();
builder.Services.AddScoped<EventProxyModule>();

await builder.Services.AddGlobalForWasmAsync(builder.HostEnvironment.BaseAddress);

builder.RootComponents.Add(typeof(App), "#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add services to the container.
await builder.Services.AddMasaBlazor(builder =>
{
    builder.ConfigureTheme(theme =>
    {
        theme.Themes.Light.Primary = "#7367f0";
    });
}).AddI18nForWasmAsync(Path.Combine(builder.HostEnvironment.BaseAddress, "i18n"));

builder.Services.AddCaller("TokenBlog.Caller", options =>
{

});

await builder.Build().RunAsync();
