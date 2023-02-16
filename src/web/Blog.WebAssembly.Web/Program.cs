using Blog.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blog.WebAssembly.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
StorageService.WebAssemblyBaseAddress = builder.HostEnvironment.BaseAddress;
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlogComponent();
builder.Services.AddBlogHttpApiClient();
builder.Services.AddScoped<StorageService>();

await builder.Build().RunAsync();