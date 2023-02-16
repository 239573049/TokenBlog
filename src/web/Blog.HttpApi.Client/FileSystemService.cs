namespace Blog.HttpClient;

public class FileSystemService : IFileSystemService
{
    private readonly IHttpClientFactory _httpClientFactory;

    private const string Prefix = "/api/File/Uploading";

    public FileSystemService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<string> Uploading(Stream stream, string fileName)
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        var content = new MultipartFormDataContent();
        content.Add(new ByteArrayContent(await stream.GetAllBytesAsync()), "file", fileName);
        var message = await http.PostAsync(Prefix, content);
        return await message.Content.ReadAsStringAsync();
    }
}