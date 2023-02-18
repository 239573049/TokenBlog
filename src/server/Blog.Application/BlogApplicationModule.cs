using Blog.Options;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;

namespace Blog;

[DependsOn(
    typeof(BlogDomainModule),
    typeof(BlogApplicationContractsModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class BlogApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        context.Services.Configure<GiteeAuthOptions>(configuration.GetSection(nameof(GiteeAuthOptions)));

        context.Services.AddHttpClient();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<BlogApplicationModule>();
        });
    }
}
