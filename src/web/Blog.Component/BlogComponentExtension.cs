using Blog.Component;
using Token.Extensions;

namespace Microsoft.Extensions.DependencyInjection;

public static class BlogComponentExtension
{
    public static IServiceCollection AddBlogComponent(this IServiceCollection services)
    {
        services.AddMasaBlazor();
        services.AddEventBus();
        services.AddScoped<HelperJsInterop>();
        return services;
    }
}