using Blog.EntityFrameworkCore;
using Blog.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;

namespace Blog;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BlogApplicationModule),
    typeof(BlogEntityFrameworkCoreModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpSwashbuckleModule)
)]
public class BlogHttpApiHostModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        var mssql = Environment.GetEnvironmentVariable("MSSQL");
        var clientId = Environment.GetEnvironmentVariable("GitHubAuthOptions:ClientId");
        var clientSecret = Environment.GetEnvironmentVariable("GitHubAuthOptions:ClientSecret");
        var callback = Environment.GetEnvironmentVariable("GitHubAuthOptions:Callback");

        if (!clientId.IsNullOrEmpty())
        {
            configuration["GitHubAuthOptions:ClientId"] = clientId;
        }
        if (!clientSecret.IsNullOrEmpty())
        {
            configuration["GitHubAuthOptions:ClientSecret"] = clientSecret;
        }

        if (!callback.IsNullOrEmpty())
        {
            configuration["GitHubAuthOptions:Callback"] = callback;
        }

        if (!mssql.IsNullOrEmpty())
        {
            configuration["ConnectionStrings:Default"] = mssql;
        }

        ConfigureConventionalControllers();
        ConfigureAuthentication(context, configuration);
        ConfigureCors(context.Services);
        ConfigureSwaggerServices(context);
    }

    private void ConfigureConventionalControllers()
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(BlogApplicationModule).Assembly);
        });
    }

    private void ConfigureAuthentication(ServiceConfigurationContext context, IConfiguration configuration)
    {

        context.Services.Configure<JWTOptions>(configuration.GetSection(nameof(JWTOptions)));

        var jwt = configuration.GetSection(nameof(JWTOptions)).Get<JWTOptions>();
        context.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, //是否在令牌期间验证签发者 
                    ValidateAudience = true, //是否验证接收者 
                    ValidateLifetime = true, //是否验证失效时间 
                    ValidateIssuerSigningKey = true, //是否验证签名 
                    ValidAudience = jwt.Audience, //接收者 
                    ValidIssuer = jwt.Issuer, //签发者，签发的Token的人 
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecretKey!)) // 密钥 
                };
            });
    }

    private static void ConfigureSwaggerServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "Test API", Version = "v1" });
            options.DocInclusionPredicate((docName, description) => true);
            options.CustomSchemaIds(type => type.FullName);
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Id = "Bearer",
                            Type = ReferenceType.SecurityScheme
                        }
                    },
                    Array.Empty<string>()
                }
            });

            // 添加Authorization的输入框
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "Please enter into field the word 'Bearer' followed by a space and the JWT value,Format: Bearer {token}",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });
        });
    }

    private void ConfigureCors(IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder.SetIsOriginAllowed((string _) => true).AllowAnyMethod().AllowAnyHeader()
                    .AllowCredentials();
            });
        });
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        app.UseStaticFiles();
        app.UseRouting();
        app.UseCors();

        app.UseSwagger();
        app.UseAbpSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API");
        });


        app.UseAuthentication();
        app.UseAuthorization();
        app.UseAuditing();
        app.UseAbpSerilogEnrichers();
        app.UseUnitOfWork();
        app.UseConfiguredEndpoints();
    }
}
