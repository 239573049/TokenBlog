using Blog.Settings;
using System.Net.Http.Json;
using Volo.Abp.Settings;

namespace Blog
{
    public class SettingService : ISettingService
    {
        private readonly HttpClient _httpClient;

        private const string Prefix = "/api/app/setting";

        public SettingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SetAsync(string name, string value)
        {
            await _httpClient.PostAsync(Prefix + "/set?name=" + name + "&value=" + value, null);
        }

        public async Task<string?> GetAsync(string name)
        {
            return await _httpClient.GetStringAsync(Prefix + "?name=" + name);
        }

        public async Task<List<SettingValue>> AllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<SettingValue>>(Prefix + "/all");
        }
    }
}