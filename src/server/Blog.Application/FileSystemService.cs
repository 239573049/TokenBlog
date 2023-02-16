using Volo.Abp.Application.Services;

namespace Blog;

public class FileSystemService : ApplicationService, IFileSystemService
{
    public async Task<string> Uploading(Stream stream, string fileName)
    {
        var path = Path.Combine(AppContext.BaseDirectory, "wwwroot", "file");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        await using var fileStream = File.Create(Path.Combine(path, fileName));
        await stream.CopyToAsync(fileStream);
        await fileStream.FlushAsync();
        fileStream.Close();
        
        return "file/" + fileName;
    }
}