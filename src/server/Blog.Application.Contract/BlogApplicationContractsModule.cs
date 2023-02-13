using Volo.Abp.Modularity;

namespace Blog;

[DependsOn(
    typeof(BlogDomainSharedModule)
)]
public class BlogApplicationContractsModule : AbpModule
{
}
