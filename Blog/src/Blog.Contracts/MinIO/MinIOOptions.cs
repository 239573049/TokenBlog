namespace Blog.Contracts.MinIO;

public class MinIOOptions
{
    public string endpoint { get; set; }
    public string accessKey { get; set; }
    public string bucketName { get; set; }
    public int port { get; set; }
    public string secretKey { get; set; }
}
