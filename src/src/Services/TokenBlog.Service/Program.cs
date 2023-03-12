using TokenBlog.Service.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// If this service does not need to call other services, you can delete the following line.
builder.Services.AddDaprClient();
builder.Services.AddControllers();

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

builder.Services
    .AddFluentValidation(options =>
    {
        options.RegisterValidatorsFromAssemblyContaining<Program>();
    });

builder.Services.AddMasaDbContext<BlogDbContext>(optionsBuilder =>
{
    optionsBuilder.UseFilter();//启用数据过滤，由`Masa.Contrib.Data.Contracts`提供
    optionsBuilder.UseSqlServer();//使用SqlServer数据库，也可自行选择其它实现
});

builder.Services.AddEventBus(eventBusBuilder =>
{
    eventBusBuilder.UseMiddleware(typeof(ValidatorMiddleware<>));
    eventBusBuilder.UseMiddleware(typeof(LogMiddleware<>));
});

builder.Services.AddAutoInject();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();


// Used for Dapr Pub/Sub.
app.UseCloudEvents();
app.UseEndpoints(endpoints =>
{
    endpoints.MapSubscribeHandler();
});

app.MapControllers();

app.Run();