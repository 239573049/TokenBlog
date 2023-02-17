
namespace Blog;

public class FileSystemService : IFileSystemService
{
    private readonly HttpClient _httpClient;

    private const string Prefix = "/api/File/Uploading";

    public FileSystemService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> Uploading(Stream stream, string fileName)
    {
        var content = new MultipartFormDataContent();
        using var memoryStream = new MemoryStream();
        await stream.CopyToAsync(memoryStream);
        content.Add(new ByteArrayContent(memoryStream.ToArray()), "file", fileName);
        var message = await _httpClient.PostAsync(Prefix, content);
        return await message.Content.ReadAsStringAsync();
    }
}