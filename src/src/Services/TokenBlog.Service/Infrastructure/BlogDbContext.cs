using TokenBlog.Service.Order.Infrastructure.Entities;

namespace TokenBlog.Service.Infrastructure;

public class BlogDbContext : MasaDbContext<BlogDbContext>
{
    public DbSet<Tab> Tabs { get; set; } = default!;

    public DbSet<TabItem> TabItems { get; set; } = default!;

    public DbSet<Blogger> Bloggers { get; set; } = default!;

    public DbSet<OAuthUserInfo> OAuthUserInfos { get; set; } = default!;

    public DbSet<UserInfo> UserInfos { get; set; } = default!;

    public BlogDbContext(MasaDbContextOptions<BlogDbContext> options):base(options)
    {

    }

    protected override void OnModelCreatingExecuting(ModelBuilder builder)
    {
        base.OnModelCreatingExecuting(builder);

        builder.Entity<Tab>(options =>
        {
            options.HasIndex(x=>x.Id);
            options.HasKey(x=>x.Id);

            options.Property(x => x.Name)
                .HasComment("标签名称");

            options.HasKey(x => x.Name);
            options.HasIndex(x => x.Name);
            
        });

        builder.Entity<TabItem>(options =>
        {
            options.HasIndex(x => x.Id);
            options.HasKey(x => x.Id);

            options.HasIndex(x=>x.TabId);
            options.HasIndex(x => x.BloggerId);
        });

        builder.Entity<Blogger>(options =>
        {
            options.HasIndex(x => x.Id);
            options.HasKey(x => x.Id);

            options.HasIndex(x => x.UserId);
            options.HasIndex(x => x.Title);

        });

        builder.Entity<UserInfo>(options =>
        {
            options.HasIndex(x => x.Id);
            options.HasKey(x => x.Id);

        });

    }
}