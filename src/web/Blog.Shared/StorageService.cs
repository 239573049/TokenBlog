namespace Blog.Shared
{
    public class StorageService
    {
        #if DEBUG
        public static string BaseAddress = "https://localhost:44366/";
        #else
        public static string BaseAddress = "http://blog-api/";
        #endif

        public static string WebAssemblyBaseAddress { get; set; }
    }
}