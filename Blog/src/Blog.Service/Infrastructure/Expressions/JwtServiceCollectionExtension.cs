using Blog.Contracts.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Blog.Service.Infrastructure.Expressions;

public static class JwtServiceCollectionExtension
{
    /// <summary>
    /// 注册JWT Bearer认证服务的静态扩展方法
    /// </summary>
    /// <param name="services"></param>
    /// <param name="options">JWT授权的配置项</param>
    public static IServiceCollection AddJwtBearerAuthentication(this IServiceCollection services, JwtOptions options)
    {
        //使用应用密钥得到一个加密密钥字节数组
        var key = Encoding.ASCII.GetBytes(options.Secret);
        services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddCookie(cfg => cfg.SlidingExpiration = true)
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

        return services;
    }
}