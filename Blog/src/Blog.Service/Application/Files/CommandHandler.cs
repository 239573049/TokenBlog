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

    [EventHandler]
    public async Task UploadAsync(UploadCommand command)
    {
        var name = $"{Guid.NewGuid().ToString("N")}{command.name}";

        var put = new PutObjectArgs()
            .WithBucket(_minIOOptions.bucketName)
            .WithObject($"{command.type}/{name}")
            .WithObjectSize(command.stream.Length)
            .WithStreamData(command.stream);

        var result = await _minioClient.PutObjectAsync(put).ConfigureAwait(false);

        command.Result = $"https://{_minIOOptions.endpoint}:{_minIOOptions.port}/{_minIOOptions.bucketName}/{result.ObjectName}";
    }

    //[EventHandler] 本地存储 默认不使用
    //public async Task LoFile(UploadCommand command)
    //{
    //    // 生成唯一的文件名
    //    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(command.name);

    //    fileName = Guid.NewGuid().ToString("N") + fileName;

    //    // 保存图片到服务器
    //    var path = Path.Combine(_webHostEnvironment.WebRootPath, command.type);
    //    var filePath = Path.Combine(path, fileName);
    //    if (!Directory.Exists(path))
    //    {
    //        Directory.CreateDirectory(path);
    //    }

    //    using (var stream = new FileStream(filePath, FileMode.Create))
    //    {
    //        await command.stream.CopyToAsync(stream);

    //        command.Result = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/images/{fileName}";
    //    }
    //}
}
