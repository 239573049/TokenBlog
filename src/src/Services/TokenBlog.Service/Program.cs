var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// If this service does not need to call other services, you can delete the following line.
builder.Services.AddDaprClient();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

builder.Services
    .AddFluentValidation(options =>
    {
        options.RegisterValidatorsFromAssemblyContaining<Program>();
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