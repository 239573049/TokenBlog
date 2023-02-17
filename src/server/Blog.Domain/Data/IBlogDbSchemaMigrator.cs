using System.Threading.Tasks;

namespace Blog.Data;

public interface IBlogDbSchemaMigrator
{
    Task MigrateAsync();
}
