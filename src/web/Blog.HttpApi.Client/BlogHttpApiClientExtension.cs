using Blog;
using Blog.Blog;
using Blog.Settings;
using Blog.Shared;
using Blog.Users;

namespace Microsoft.Extensions.DependencyInjection;

public static class BlogHttpApiClientExtension
{
    public static IServiceCollection AddBlogHttpApiClient(this IServiceCollection services)
    {
        // Server 会共享同一个token所以使用Scoped
        services.AddScoped(services => new HttpClient
        {
            BaseAddress = new Uri(StorageService.BaseAddress)
        });

        services.AddScoped<IUserInfoService, UserInfoService>();
        services.AddScoped<ITagService, TagService>();
        services.AddScoped<IArticleService, ArticleService>();
        services.AddScoped<IFileSystemService, FileSystemService>();
        services.AddScoped<IArticleCommentService, ArticleCommentService>();
        services.AddScoped<ISettingService, SettingService>();

        return services;
    }
}