using Blog.Blog;
using Blog.HttpClient;
using Blog.Users;

namespace Microsoft.Extensions.DependencyInjection;

public static class BlogHttpApiClientExtension
{
    public static string Token { get; private set; } = string.Empty;

    public static void SetToken(string token)
    {
        Token = token;
    }

    public static IServiceCollection AddBlogHttpApiClient(this IServiceCollection services)
    {
        services.AddScoped<IUserInfoService, UserInfoService>();
        services.AddScoped<ITagService, TagService>();
        services.AddScoped<IArticleService, ArticleService>();

        services.AddHttpClient(string.Empty, options =>
        {
            options.BaseAddress = new Uri("http://localhost:5202");
            options.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);
        });

        return services;
    }
}