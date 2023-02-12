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
