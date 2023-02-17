using Volo.Abp.AuditLogging;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.SettingManagement;

namespace Blog;

[DependsOn(
    typeof(BlogDomainSharedModule),
    typeof(AbpAuditLoggingDomainModule),
    typeof(AbpPermissionManagementDomainIdentityModule),
    typeof(AbpSettingManagementDomainModule)
)]
public class BlogDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Languages.Add(new LanguageInfo("en", "en", "English", "gb"));
            options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文"));
        });

    }
}
