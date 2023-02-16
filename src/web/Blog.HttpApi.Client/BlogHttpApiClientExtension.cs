using Blog;
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
        services.AddScoped<IFileSystemService,FileSystemService>();
        services.AddScoped<IArticleCommentService, ArticleCommentService>();
        
        services.AddHttpClient(string.Empty, options =>
        {
            options.BaseAddress = new Uri(StorageService.BaseAddress);
            options.DefaultRequestHeaders.Add("Authorization", "Bearer " + StorageService.Token);
        });

        return services;
    }
}