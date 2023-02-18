using System.Text.Json.Serialization;

namespace Blog.Options;

public class GiteeAuthOptions
{
    public string ClientId { get; set; }

    public string ClientSecret { get; set; }

    /// <summary>
    /// 回调地址
    /// </summary>
    public string Callback { get; set; }
}

public class AccessTokenModel
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }
}