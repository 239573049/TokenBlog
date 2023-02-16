using Blog.Blog;
using Blog.HttpClient;
using Blog.Shared;
using Blog.Users;

namespace Microsoft.Extensions.DependencyInjection;

public static class BlogHttpApiClientExtension
{
    public static IServiceCollection AddBlogHttpApiClient(this IServiceCollection services)
    {
        services.AddScoped<IUserInfoService, UserInfoService>();
        services.AddScoped<ITagService, TagService>();
        services.AddScoped<IArticleService, ArticleService>();
        services.AddScoped<FileSystemService>();
        
        services.AddHttpClient(string.Empty, options =>
        {
            options.BaseAddress = new Uri("http://localhost:5202");
            options.DefaultRequestHeaders.Add("Authorization", "Bearer " + StorageService.Token);
        });

        return services;
    }
}