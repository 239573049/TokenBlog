using Blog.Service.Domain.Bloggers.Aggregates;

namespace Blog.Service.Infrastructure;

public class BlogDbContext : MasaDbContext
{
    public DbSet<Article> Articles { get; set; } = null!;

    public DbSet<Category> Categories { get; set; } = null!;

    public DbSet<Tab> Tabs { get; set; } = null!;

    public BlogDbContext(MasaDbContextOptions<BlogDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreatingExecuting(ModelBuilder modelBuilder)
    {
        base.OnModelCreatingExecuting(modelBuilder);
        ConfigEntities(modelBuilder);
    }

    private static void ConfigEntities(ModelBuilder builder)
    {
        builder.Entity<Article>(options =>
        {
            options.HasIndex(x => x.Id).IsUnique();

            options.HasIndex(x => x.Title);

            options.HasIndex(x => x.CategoryId);

            options.HasIndex(x => x.UserId);

            options.Property(x => x.Content).HasMaxLength(10000);

            options.Property(x => x.CategoryId).HasComment("分类id");
            options.Property(x => x.Title).HasComment("标题");
            options.Property(x => x.UserId).HasComment("用户id");
            options.Property(x => x.Content).HasComment("文章内容");
            options.Property(x => x.PublishTime).HasComment("发布时间");
            options.Property(x => x.Tabs).HasComment("标签id json数组格式");
            options.Property(x => x.Like).HasComment("点赞量");
            options.Property(x => x.ReadCount).HasComment("阅读量");
        });
        
        
    }
}