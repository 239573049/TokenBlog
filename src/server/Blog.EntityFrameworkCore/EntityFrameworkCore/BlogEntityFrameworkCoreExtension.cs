using Blog.Blog;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Blog.EntityFrameworkCore;

public static class BlogEntityFrameworkCoreExtension
{
    public static void ConfigureBlog(this ModelBuilder builder)
    {
        builder.Entity<Article>(options =>
        {
            options.ToTable("Articles");

            options.ConfigureByConvention();

            options.HasIndex(x => x.Description);
            options.HasIndex(x => x.Title);
        });

        builder.Entity<Tag>(options =>
        {
            options.ToTable("Tags");

            options.ConfigureByConvention();

            options.HasIndex(x => x.Title).IsUnique();
        });

        builder.Entity<TagRelevanceArticle>(options =>
        {
            options.ToTable("TagRelevanceArticles");

            options.ConfigureByConvention();

            options.HasIndex(x => x.TagId);
            options.HasIndex(x => x.ArticleId);
        });

        builder.Entity<ArticleComment>(options =>
        {
            options.ToTable("ArticleComments");

            options.ConfigureByConvention();

            options.HasIndex(x => x.UserId);
            options.HasIndex(x => x.ParentId);
            options.HasIndex(x => x.ArticleId);
        });

        builder.Entity<UserInfo>(options =>
        {
            options.ToTable("UserInfos");

            options.ConfigureByConvention();

            options.HasIndex(x => x.GitHubId);
        });
    }
}