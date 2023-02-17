using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Uow;

namespace Blog.OpenIddict;

/* Creates initial data that is needed to property run the application
 * and make client-to-server communication possible.
 */
public class OpenIddictDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IConfiguration _configuration;
    private readonly IPermissionDataSeeder _permissionDataSeeder;

    public OpenIddictDataSeedContributor(
        IConfiguration configuration,
        IPermissionDataSeeder permissionDataSeeder)
    {
        _configuration = configuration;
        _permissionDataSeeder = permissionDataSeeder;
    }

    [UnitOfWork]
    public virtual async Task SeedAsync(DataSeedContext context)
    {
    }
}
