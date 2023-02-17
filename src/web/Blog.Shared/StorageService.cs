namespace Blog.Shared
{
    public class StorageService
    {
        #if DEBUG
        public static string BaseAddress = "https://localhost:44366/";
        #else
        public static string BaseAddress = "http://api.blog.tokengo.top/";
        #endif

        public static string WebAssemblyBaseAddress { get; set; }
    }
}