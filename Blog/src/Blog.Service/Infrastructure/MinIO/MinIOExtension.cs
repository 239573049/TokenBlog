using Blog.Contracts.MinIO;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Options;
using Minio;

namespace Blog.Service.Infrastructure.MinIO;

public static class MinIOExtension
{
    public static IServiceCollection AddMinIO(this IServiceCollection services, IConfiguration configuration)
    {
        var config = configuration.GetSection("MinIO");
        services.Configure<MinIOOptions>(config);

        services.AddSingleton<MinioClient>((server) =>
        {
            var config = server.GetRequiredService<IOptions<MinIOOptions>>().Value;

            var client = new MinioClient()
                .WithEndpoint(config.endpoint, config.port)
                .WithCredentials(config.accessKey, config.secretKey)
                .WithSSL()
                .Build();

            // 初始化之前判断桶是否存在
            var beArgs = new BucketExistsArgs()
                    .WithBucket(config.bucketName);

            bool found = client.BucketExistsAsync(beArgs).ConfigureAwait(false).GetAwaiter().GetResult();
            if (!found)
            {
                var mbArgs = new MakeBucketArgs()
                    .WithBucket(config.bucketName);
                client.MakeBucketAsync(mbArgs).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            return client;
        });
        return services;
    }
}
