using Blog.Contracts.MinIO;
using Blog.Service.Application.Files.Commands;
using Microsoft.Extensions.Options;
using Minio;

namespace Blog.Service.Application.Files;

public class CommandHandler
{
    private readonly MinioClient _minioClient;
    private readonly MinIOOptions _minIOOptions;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CommandHandler(MinioClient minioClient, IOptions<MinIOOptions> minIOOptions, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
    {
        _minioClient = minioClient;
        _minIOOptions = minIOOptions.Value;
        _webHostEnvironment = webHostEnvironment;
        _httpContextAccessor = httpContextAccessor;
    }

    [EventHandler(1)]
    public async Task MinIOFileAsync(UploadCommand command)
    {
        // 生成随机名称
        var name = $"{Guid.NewGuid():N}{command.name}";

        // 创建Put对象将上传Stream到MinIO
        var put = new PutObjectArgs()
            .WithBucket(_minIOOptions.bucketName)
            .WithObject($"{command.type}/{name}")
            .WithObjectSize(command.stream.Length)
            .WithStreamData(command.stream);

        // 上传文件到MinIO
        var result = await _minioClient.PutObjectAsync(put).ConfigureAwait(false);

        // 通过配置的域名、端口、桶名、文件名拼接访问路径
        command.Result = $"https://{_minIOOptions.endpoint}:{_minIOOptions.port}/{_minIOOptions.bucketName}/{result.ObjectName}";
    }


    [EventHandler(2)] 
    public async Task LocalFileAsync(UploadCommand command)
    {
        // 生成唯一的文件名
        //var fileName = Guid.NewGuid().ToString() + Path.GetExtension(command.name);

        //fileName = Guid.NewGuid().ToString("N") + fileName;

        //// 保存图片到服务器
        //var path = Path.Combine(_webHostEnvironment.WebRootPath, command.type);
        //var filePath = Path.Combine(path, fileName);
        //if (!Directory.Exists(path))
        //{
        //    Directory.CreateDirectory(path);
        //}

        //await using var stream = new FileStream(filePath, FileMode.Create);

        //await command.stream.CopyToAsync(stream);

        //command.Result = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/images/{fileName}";
    }
}
