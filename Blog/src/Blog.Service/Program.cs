using Blog.Contracts.Auth;
using Blog.Service.Infrastructure;
using Blog.Service.Infrastructure.Expressions;
using Blog.Service.Infrastructure.Middleware;
using Blog.Service.Infrastructure.MinIO;
using FreeRedis;
using Masa.BuildingBlocks.Data.UoW;
using Masa.BuildingBlocks.Dispatcher.IntegrationEvents;
using Masa.BuildingBlocks.Dispatcher.IntegrationEvents.Logs;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services
    .AddAuthentication();

// 设置上传文件的最大大小
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 268435456;
});

#region Jwt

var jwtSection = builder.Configuration.GetSection("Jwt");
builder.Services.Configure<JwtOptions>(jwtSection);
var jwtOptions = jwtSection.Get<JwtOptions>();

#endregion

// 增加注入Redis客户端
builder.Services.AddSingleton((service) => new RedisClient(builder.Configuration["ConnectionStrings:Redis"]));

var app = builder.Services
    .AddSingleton<IActionContextAccessor, ActionContextAccessor>()
    .AddAuthorization()
    .AddMasaIdentity() // 使用到Masa提供的用户信息接口需要注入
    .AddMinIO(builder.Configuration)
    .AddTransient<AnomalyMiddleware>() // 添加注入异常中间件
    .AddJwtBearerAuthentication(jwtOptions) // 注入JWT授权
    .AddCors(options => // 注入跨域策略
    {
        options.AddPolicy("CorsPolicy", corsBuilder =>
        {
            corsBuilder.SetIsOriginAllowed((string _) => true).AllowAnyMethod().AllowAnyHeader()
                .AllowCredentials();
        });
    })
    .AddHttpClient() // 注入Http客户端用于发起请求
    .AddEndpointsApiExplorer() 
    .AddSwaggerGen(options => // 注入Swagger用于文档查看
    {
        options.SwaggerDoc("v1", new OpenApiInfo { Title = "BlogApp", Version = "v1", Contact = new OpenApiContact { Name = "BlogApp", } });
        foreach (var item in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.xml")) options.IncludeXmlComments(item, true);
        options.DocInclusionPredicate((docName, action) => true);
    })
    .AddEventBus() // 注入进程内事件总线
    .AddMasaDbContext<BlogDbContext>(opt => // 注入Masa的DbContext
    {
        opt.UseNpgsql(builder.Configuration["ConnectionStrings:DefaultConnection"]);
    })
    .AddDomainEventBus(dispatcherOptions => // 注入领域事件总线
    {
        dispatcherOptions
            .UseIntegrationEventBus<IIntegrationEventLogService>(options =>
            {
                options.UseDapr()
                    .UseEventLog<BlogDbContext>();
            })
            .UseEventBus(eventBusBuilder =>
            {
                // 添加事件中间件
                eventBusBuilder.UseMiddleware(typeof(ValidatorMiddleware<>));
                eventBusBuilder.UseMiddleware(typeof(LogMiddleware<>));
            })
            .UseUoW<BlogDbContext>()
            .UseRepository<BlogDbContext>();
    })
    .AddAutoInject() // 注入自动注入
    .AddServices(builder, option => option.MapHttpMethodsForUnmatched = new string[] { "Post" });

app.UseMiddleware<AnomalyMiddleware>(); // 使用异常中间件

//app.UseMasaExceptionHandler();
app.UseCors("CorsPolicy"); // 使用Cors策略

app.UseStaticFiles(); // 使用静态文件中间件以便支持上传的文件允许访问

if (app.Environment.IsDevelopment())
{
    app.UseSwagger().UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "BlogApp"));

    #region MigrationDb
    using var context = app.Services.CreateScope().ServiceProvider.GetService<BlogDbContext>();
    {
        context!.Database.Migrate();
        if (context!.GetService<IRelationalDatabaseCreator>().HasTables() == false)
        {
            context!.GetService<IRelationalDatabaseCreator>().CreateTables();
        }
    }
    #endregion
}

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

await app.RunAsync();
