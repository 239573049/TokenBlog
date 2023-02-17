namespace Blog.Options;

public class JWTOptions
{
    public string SecretKey { get; set; }

    public string Issuer { get; set; }

    public string Audience { get; set; }

    public int ExpireMinutes { get; set; }
}