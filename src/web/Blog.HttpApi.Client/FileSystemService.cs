
namespace Blog;

public class FileSystemService : IFileSystemService
{
    private readonly System.Net.Http.HttpClient _httpClient;

    private const string Prefix = "/api/File/Uploading";

    public FileSystemService(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> Uploading(Stream stream, string fileName)
    {
        var content = new MultipartFormDataContent();
        content.Add(new ByteArrayContent(await stream.GetAllBytesAsync()), "file", fileName);
        var message = await _httpClient.PostAsync(Prefix, content);
        return await message.Content.ReadAsStringAsync();
    }
}