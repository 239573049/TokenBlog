namespace Blog.Shared
{
    public static class StorageService
    {
        public const string BaseAddress = "http://localhost:5202";
        public static string Token { get; private set; } = string.Empty;

        public static void SetToken(string token)
        {
            Token = token;
        }
    }
}