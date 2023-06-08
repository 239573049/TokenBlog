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

// �����ϴ��ļ�������С
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 268435456;
});

#region Jwt

var jwtSection = builder.Configuration.GetSection("Jwt");
builder.Services.Configure<JwtOptions>(jwtSection);
var jwtOptions = jwtSection.Get<JwtOptions>();

#endregion

// ����ע��Redis�ͻ���
builder.Services.AddSingleton((service) => new RedisClient(builder.Configuration["ConnectionStrings:Redis"]));

var app = builder.Services
    .AddSingleton<IActionContextAccessor, ActionContextAccessor>()
    .AddAuthorization()
    .AddMasaIdentity() // ʹ�õ�Masa�ṩ���û���Ϣ�ӿ���Ҫע��
    .AddMinIO(builder.Configuration)
    .AddTransient<AnomalyMiddleware>() // ���ע���쳣�м��
    .AddJwtBearerAuthentication(jwtOptions) // ע��JWT��Ȩ
    .AddCors(options => // ע��������
    {
        options.AddPolicy("CorsPolicy", corsBuilder =>
        {
            corsBuilder.SetIsOriginAllowed((string _) => true).AllowAnyMethod().AllowAnyHeader()
                .AllowCredentials();
        });
    })
    .AddHttpClient() // ע��Http�ͻ������ڷ�������
    .AddEndpointsApiExplorer() 
    .AddSwaggerGen(options => // ע��Swagger�����ĵ��鿴
    {
        options.SwaggerDoc("v1", new OpenApiInfo { Title = "BlogApp", Version = "v1", Contact = new OpenApiContact { Name = "BlogApp", } });
        foreach (var item in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.xml")) options.IncludeXmlComments(item, true);
        options.DocInclusionPredicate((docName, action) => true);
    })
    .AddEventBus() // ע��������¼�����
    .AddMasaDbContext<BlogDbContext>(opt => // ע��Masa��DbContext
    {
        opt.UseNpgsql(builder.Configuration["ConnectionStrings:DefaultConnection"]);
    })
    .AddDomainEventBus(dispatcherOptions => // ע�������¼�����
    {
        dispatcherOptions
            .UseIntegrationEventBus<IIntegrationEventLogService>(options =>
            {
                options.UseDapr()
                    .UseEventLog<BlogDbContext>();
            })
            .UseEventBus(eventBusBuilder =>
            {
                // ����¼��м��
                eventBusBuilder.UseMiddleware(typeof(ValidatorMiddleware<>));
                eventBusBuilder.UseMiddleware(typeof(LogMiddleware<>));
            })
            .UseUoW<BlogDbContext>()
            .UseRepository<BlogDbContext>();
    })
    .AddAutoInject() // ע���Զ�ע��
    .AddServices(builder, option => option.MapHttpMethodsForUnmatched = new string[] { "Post" });

app.UseMiddleware<AnomalyMiddleware>(); // ʹ���쳣�м��

//app.UseMasaExceptionHandler();
app.UseCors("CorsPolicy"); // ʹ��Cors����

app.UseStaticFiles(); // ʹ�þ�̬�ļ��м���Ա�֧���ϴ����ļ��������

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
