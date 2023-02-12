using Blog.Options;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;

namespace Blog;

[DependsOn(
    typeof(BlogDomainModule),
    typeof(BlogApplicationContractsModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class BlogApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        
        context.Services.Configure<GitHubAuthOptions>(configuration.GetSection(nameof(GitHubAuthOptions)));
        
        context.Services.AddHttpClient();
        
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<BlogApplicationModule>();
        });

    }
}
