using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;

namespace Blog;

[DependsOn(
    typeof(BlogDomainSharedModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class BlogApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        BlogDtoExtensions.Configure();
    }
}
