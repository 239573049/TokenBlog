using System.Net.Http.Headers;
using Blog;
using Blog.Blog;
using Blog.Shared;
using Blog.Users;

namespace Microsoft.Extensions.DependencyInjection;

public static class BlogHttpApiClientExtension
{
    public static IServiceCollection AddBlogHttpApiClient(this IServiceCollection services)
    {
        services.AddScoped<HttpClient>( services => new HttpClient
        {
            BaseAddress = new Uri(StorageService.BaseAddress)
        });
        
        services.AddScoped<IUserInfoService, UserInfoService>();
        services.AddScoped<ITagService, TagService>();
        services.AddScoped<IArticleService, ArticleService>();
        services.AddScoped<IFileSystemService, FileSystemService>();
        services.AddScoped<IArticleCommentService, ArticleCommentService>();


        return services;
    }
}