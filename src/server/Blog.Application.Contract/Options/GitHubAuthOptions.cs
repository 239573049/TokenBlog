using System.Text.Json.Serialization;

namespace Blog.Options;

public class GitHubAuthOptions
{
    public required string ClientId { get; set; }

    public required string ClientSecret { get; set; }

    /// <summary>
    /// 回调地址
    /// </summary>
    public required string Callback { get; set; }
}

public class AccessTokenModel
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }
}