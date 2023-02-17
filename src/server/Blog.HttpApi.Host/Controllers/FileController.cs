using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Blog.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class FileController : ControllerBase
{
    private readonly IFileSystemService _fileSystemService;

    public FileController(IFileSystemService fileSystemService)
    {
        _fileSystemService = fileSystemService;
    }

    [HttpPost]
    public async Task<string> Uploading(IFormFile file)
    {
        // 5MB
        if (file.Length > 41943040)
        {
            throw new BusinessException("上传文件大于5MB无法上传");
        }

        var name = Guid.NewGuid().ToString("N") + file.FileName;

        return await _fileSystemService.Uploading(file.OpenReadStream(), name);
    }
}