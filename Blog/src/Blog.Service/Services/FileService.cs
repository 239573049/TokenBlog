using Blog.Service.Application.Files.Commands;
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

        var command = new UploadCommand(file.OpenReadStream(), file.FileName, "image");
        await eventBus.PublishAsync(command);
        return command.Result;

    }

    [Authorize]
    public async Task<string> UploadFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            throw new UserFriendlyException("请选择要上传的文件");
        }

        var command = new UploadCommand(file.OpenReadStream(), file.FileName, "file");

        await eventBus.PublishAsync(command);

        return command.Result;
    }
}