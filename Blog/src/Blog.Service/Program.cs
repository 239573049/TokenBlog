using Blog.Service.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Services
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
        opt.UseNpgsql();
    })
    .AddAutoInject()
    .AddServices(builder, option => option.MapHttpMethodsForUnmatched = new string[] { "Post" });

app.UseMasaExceptionHandler();

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

app.Run();
