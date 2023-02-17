using Blog.Shared;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor()
    .AddHubOptions(options =>
    {
        options.ClientTimeoutInterval = TimeSpan.FromSeconds(30);
        options.EnableDetailedErrors = false;
        options.HandshakeTimeout = TimeSpan.FromSeconds(15);
        options.KeepAliveInterval = TimeSpan.FromSeconds(15);
        options.MaximumParallelInvocationsPerClient = 1;
        options.MaximumReceiveMessageSize = 1024 * 1024;
        options.StreamBufferCapacity = 100;
    });;
builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});

builder.Services.AddScoped<StorageService>();
builder.Services.AddBlogComponent();
builder.Services.AddBlogHttpApiClient();

builder.Services.AddScoped<HttpClient>(services => new HttpClient
{
    BaseAddress = new Uri(StorageService.BaseAddress)
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub(options =>
{
    options.ApplicationMaxBufferSize = 1024 * 1024 * 1024;
    options.TransportMaxBufferSize = 1024 * 1024 * 1024;
});
app.MapFallbackToPage("/_Host");

app.Run();