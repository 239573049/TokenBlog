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

            options.HasIndex(x => x.Title).IsUnique();
        });

        builder.Entity<TagRelevanceArticle>(options =>
        {
            options.ToTable("TagRelevanceArticles");

            options.HasIndex(x => x.TagId);
            options.HasIndex(x => x.ArticleId);
        });

        builder.Entity<ArticleColumns>(options =>
        {
            options.ToTable("ArticleColumns");

            options.HasIndex(x => x.Title).IsUnique();
        });

        builder.Entity<ArticleComment>(options =>
        {
            options.ToTable("ArticleComments");

            options.HasIndex(x => x.UserId);
            options.HasIndex(x => x.ParentId);
            options.HasIndex(x => x.ArticleId);
        });
        
    }
}