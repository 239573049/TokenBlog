using Blog.Shared;
using Blog.WebAssembly.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
StorageService.WebAssemblyBaseAddress = builder.HostEnvironment.BaseAddress;
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var handler = new HttpClientHandler();

if (builder.HostEnvironment.Environment.StartsWith("https://"))
{
    StorageService.BaseAddress = StorageService.BaseAddress.Replace("https:", "http:");
}

builder.Services.AddScoped(services => new HttpClient
{
    BaseAddress = new Uri(StorageService.BaseAddress)
});

builder.Services.AddBlogComponent();
builder.Services.AddBlogHttpApiClient();
builder.Services.AddScoped<StorageService>();

await builder.Build().RunAsync();