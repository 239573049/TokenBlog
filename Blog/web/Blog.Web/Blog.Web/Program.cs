using Blog.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddServerComponents()
    .AddWebAssemblyComponents();


builder.Services.AddWebApiClient().ConfigureHttpApi(o =>
{
    o.UseLogging = true;
    o.HttpHost = new Uri("http://localhost:5119/api/v1/");
});

builder.Services.AddMasaBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.MapRazorComponents<App>()
    .AddServerRenderMode()
    .AddWebAssemblyRenderMode();

app.Run();
