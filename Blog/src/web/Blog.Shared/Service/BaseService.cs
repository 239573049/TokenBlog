using System.Text;
using System.Text.Json;

namespace Blog.Shared.Service;

public abstract class BaseService
{
    private static readonly HttpClient HttpClient = new ();
    
    protected async Task PostAsync(string url, object? data)
    {
        var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        var response = await HttpClient.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
    }
    
    protected async Task<T> GetAsync<T>(string url)
    {
        var response = await HttpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
    }
    
    protected async Task DeleteAsync(string url)
    {
        var response = await HttpClient.DeleteAsync(url);
        response.EnsureSuccessStatusCode();
    }
    
    protected async Task PutAsync(string url, object? data)
    {
        var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        var response = await HttpClient.PutAsync(url, content);
        response.EnsureSuccessStatusCode();
    }
    
    protected async Task<T> PostAsync<T>(string url, object? data)
    {
        var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        var response = await HttpClient.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
    }
    
    protected async Task<T> PutAsync<T>(string url, object? data)
    {
        var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        var response = await HttpClient.PutAsync(url, content);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
    }
    
    protected async Task<T> DeleteAsync<T>(string url)
    {
        var response = await HttpClient.DeleteAsync(url);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
    }
    
    protected async Task<T> PostAsync<T>(string url)
    {
        var response = await HttpClient.PostAsync(url, null);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
    }
}