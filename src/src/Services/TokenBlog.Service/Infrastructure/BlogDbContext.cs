namespace TokenBlog.Service.Infrastructure;

public class BlogDbContext : MasaDbContext
{
    public DbSet<Order> Orders { get; set; } = default!;

    public BlogDbContext(MasaDbContextOptions<BlogDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreatingExecuting(ModelBuilder builder)
    {
        base.OnModelCreatingExecuting(builder);
    }
}