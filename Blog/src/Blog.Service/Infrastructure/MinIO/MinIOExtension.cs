using Blog.Contracts.MinIO;
using Microsoft.Extensions.Options;
using Minio;

namespace Blog.Service.Infrastructure.MinIO;

/// <summary>
/// MinIO扩展
/// </summary>
public static class MinIOExtension
{
    /// <summary>
    /// MinIO的注入方法
    /// 提供了MinIO的Options配置注入
    /// 提供了MinIO的客户端注入
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddMinIO(this IServiceCollection services, IConfiguration configuration)
    {
        var config = configuration.GetSection("MinIO");
        services.Configure<MinIOOptions>(config);

        services.AddSingleton((server) =>
        {
            // 从服务容器中获取MinIO的配置项
            var config = server.GetRequiredService<IOptions<MinIOOptions>>().Value;

            // 创建MinIO客户端
            var client = new MinioClient()
                .WithEndpoint(config.endpoint, config.port)
                .WithCredentials(config.accessKey, config.secretKey) // 默认使用匿名账户，如果需要使用账户密码则需要设置为 .WithCredentials(accessKey, secretKey)
                .WithSSL() // 默认使用SSL，如果endpoint 为 http 则需要设置为 .WithSSL(false)
                .Build();

            // 初始化之前判断桶是否存在
            var beArgs = new BucketExistsArgs()
                    .WithBucket(config.bucketName);

            // 判断桶是否存在
            bool found = client.BucketExistsAsync(beArgs).ConfigureAwait(false).GetAwaiter().GetResult();
            if (!found)
            {
                // 不存在Options中配置的桶则创建
                var mbArgs = new MakeBucketArgs()
                    .WithBucket(config.bucketName);

                client.MakeBucketAsync(mbArgs).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            return client;
        });
        return services;
    }
}
