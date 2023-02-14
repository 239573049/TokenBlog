using Blog.Blog;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class BlogDbContext :
    AbpDbContext<BlogDbContext>
{
    public DbSet<UserInfo> UserInfos { get; set; }

    public DbSet<Article> Articles { get; set; }

    public DbSet<ArticleComment> ArticleComments { get; set; }

    public DbSet<Tag> Tags { get; set; }
    
    public BlogDbContext(DbContextOptions<BlogDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureSettingManagement();
        builder.ConfigureAuditLogging();

        builder.ConfigureBlog();

    }
}
