
namespace Microsoft.Extensions.DependencyInjection;

public static class BlogComponentExtension
{
    public static IServiceCollection AddBlogComponent(this IServiceCollection services)
    {
        services.AddMasaBlazor();
        services.AddHttpClient<HttpClient>(options =>
        {
            options.BaseAddress = new Uri("http://localhost:5202");
            
        });
        return services;
    }
}