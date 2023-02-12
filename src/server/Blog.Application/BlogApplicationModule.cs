using System.Text;
using Blog.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
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

        var tokenOptions = configuration.GetValue<JWTOptions>(nameof(JWTOptions));
        context.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme) 
            .AddJwtBearer(options => 
            { 
                options.TokenValidationParameters = new TokenValidationParameters 
                { 
                    ValidateIssuer = true, //是否在令牌期间验证签发者 
                    ValidateAudience = true, //是否验证接收者 
                    ValidateLifetime = true, //是否验证失效时间 
                    ValidateIssuerSigningKey = true, //是否验证签名 
                    ValidAudience = tokenOptions!.Audience, //接收者 
                    ValidIssuer = tokenOptions.Issuer, //签发者，签发的Token的人 
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecretKey!)) // 密钥 
                }; 
            });
    }
}
