using Blog.Service.Infrastructure;
using Blog.Service.Infrastructure.Middleware;
using Masa.BuildingBlocks.Data.UoW;
using Masa.BuildingBlocks.Dispatcher.IntegrationEvents;
using Masa.BuildingBlocks.Dispatcher.IntegrationEvents.Logs;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAuthentication();

var app = builder.Services
    .AddAuthorization()
    .AddMasaIdentity()
    .AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", corsBuilder =>
        {
            corsBuilder.SetIsOriginAllowed((string _) => true).AllowAnyMethod().AllowAnyHeader()
                .AllowCredentials();
        });
    })
    .AddHttpClient()
    .AddEndpointsApiExplorer()
    .AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo { Title = "BlogApp", Version = "v1", Contact = new Microsoft.OpenApi.Models.OpenApiContact { Name = "BlogApp", } });
        foreach (var item in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.xml")) options.IncludeXmlComments(item, true);
        options.DocInclusionPredicate((docName, action) => true);
    })
    .AddEventBus()
    .AddMasaDbContext<BlogDbContext>(opt =>
    {
        opt.UseNpgsql(builder.Configuration["ConnectionStrings:DefaultConnection"]);
    })
    .AddDomainEventBus(dispatcherOptions =>
    {
        dispatcherOptions
            .UseIntegrationEventBus<IIntegrationEventLogService>(options =>
            {
                options.UseDapr()
                .UseEventLog<BlogDbContext>();

                options.MaxRetryTimes = 3;
            })
            .UseEventBus(eventBusBuilder =>
            {
                eventBusBuilder.UseMiddleware(typeof(ValidatorMiddleware<>));
                eventBusBuilder.UseMiddleware(typeof(LogMiddleware<>));
            })
            .UseUoW<BlogDbContext>()
            .UseRepository<BlogDbContext>();
        ;
    })
    .AddAutoInject()
    .AddServices(builder, option => option.MapHttpMethodsForUnmatched = new string[] { "Post" });

app.UseMasaExceptionHandler();
app.UseCors("CorsPolicy");

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

app.UseCloudEvents();
await app.RunAsync();
