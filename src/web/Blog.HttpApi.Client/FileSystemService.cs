using System.Net.Http.Json;

namespace Blog.HttpClient;

public class FileSystemService
{
    private readonly IHttpClientFactory _httpClientFactory;

    private const string Prefix = "/api/File/Uploading";

    public FileSystemService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<string?> Uploading(byte[] stream, string name)
    {
        var http = _httpClientFactory.CreateClient(string.Empty);
        var content = new MultipartFormDataContent();
        content.Add(new ByteArrayContent(stream), "file", name);
        var message = await http.PostAsync(Prefix, content);
        return await message.Content.ReadAsStringAsync();
    }
}