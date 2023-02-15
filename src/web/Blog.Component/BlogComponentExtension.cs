using Blog.Component;
using Token.Events;
using Token.Extensions;
using Token.Manager;

namespace Microsoft.Extensions.DependencyInjection;

public static class BlogComponentExtension
{
    public static IServiceCollection AddBlogComponent(this IServiceCollection services)
    {
        services.AddMasaBlazor();
        
        services.AddScoped(typeof (EventManager<>));
        services.AddScoped(typeof (ILoadEventBus<>), typeof (LoadEventBus<>));
        services.AddScoped<IKeyLoadEventBus, KeyLoadEventBus>();
        services.AddScoped<HelperJsInterop>();
        return services;
    }
}