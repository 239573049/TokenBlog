using Blog.Shared;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddServerSideBlazor()
    .AddHubOptions(options =>
    {
        options.HandshakeTimeout = TimeSpan.FromSeconds(600000); // 获取或设置服务器用于客户端传入握手请求超时的间隔
        options.ClientTimeoutInterval = TimeSpan.FromSeconds(600000); // 长时间未发送消息断开
        options.KeepAliveInterval = TimeSpan.FromSeconds(1000); // 获取或设置串行器用于向连接的客户端发送keep alive ping的间隔
        options.EnableDetailedErrors = false; // 获取或设置一个值，该值指示是否将详细错误消息发送到客户端。详细的错误消息包括来自服务器上抛出的异常的详细信息。
        options.MaximumParallelInvocationsPerClient = 1; // 默认情况下，客户端一次只允许调用一个Hub方法。更改此属性将允许客户端在排队之前同时调用多个方法。
        options.MaximumReceiveMessageSize = 1024 * 1024; // 获取或设置单个传入集线器消息的最大消息大小。默认值是32KB。
        options.StreamBufferCapacity = 100; // 获取或设置客户端上传流的最大缓冲区大小
    });

builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});

builder.Services.AddScoped<StorageService>()
    .AddBlogComponent()
    .AddBlogHttpApiClient()
    .AddScoped(services => new HttpClient
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