namespace Blog.Service.Services;

public abstract class BaseService<T> : ServiceBase where T : class
{
    internal ILogger<T> Logger => GetRequiredService<ILogger<T>>();

    internal IEventBus eventBus => GetRequiredService<IEventBus>();
    
}