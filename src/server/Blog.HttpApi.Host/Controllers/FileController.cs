using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Blog.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class FileSystemController : ControllerBase
{
    [HttpPost]
    public async Task<string> Uploading(IFormFile file)
    {
        // 5MB
        if (file.Length > 41943040)
        {
            throw new BusinessException("上传文件大于5MB无法上传");
        }

        var path = Path.Combine(AppContext.BaseDirectory, "wwwroot", "file");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var name = Guid.NewGuid().ToString("N") + file.FileName;
        await using var stream = System.IO.File.Create(Path.Combine(path, name));
        await file.OpenReadStream().CopyToAsync(stream);
        await stream.FlushAsync();
        stream.Close();

        return "file/" + name;
    }
}