using Microsoft.AspNetCore.Authorization;

namespace Blog.Service.Services;

public class FileService : BaseService<FileService>
{
    [Authorize]
    public async Task<string> UploadImage(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            throw new UserFriendlyException("请选择要上传的图片");
        }

        // 生成唯一的文件名
        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

        fileName = Guid.NewGuid().ToString("N") + fileName;

        // 保存图片到服务器
        var path = Path.Combine(GetService<IWebHostEnvironment>().WebRootPath, "images");
        var filePath = Path.Combine(path, fileName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);

            var http = GetService<IHttpContextAccessor>();

            return $"{http.HttpContext.Request.Scheme}://{http.HttpContext.Request.Host}/images/{fileName}";
        }
    }

    [Authorize]
    public async Task<string> UploadFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            throw new UserFriendlyException("请选择要上传的文件");
        }

        // 生成唯一的文件名
        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

        fileName = Guid.NewGuid().ToString("N") + fileName;

        // 保存图片到服务器
        var path = Path.Combine(GetService<IWebHostEnvironment>().WebRootPath, "files");
        var filePath = Path.Combine(path, fileName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);

            var http = GetService<IHttpContextAccessor>();

            return $"{http.HttpContext.Request.Scheme}://{http.HttpContext.Request.Host}/files/{fileName}";
        }
    }
}