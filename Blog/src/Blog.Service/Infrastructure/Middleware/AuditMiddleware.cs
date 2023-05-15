using System.Diagnostics;

namespace Blog.Service.Infrastructure.Middleware;

public class AuditMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var ip = context.Connection.RemoteIpAddress?.MapToIPv4().ToString();
        if (context.Request.Headers.ContainsKey("X-Forwarded-For"))
        {
            ip = context.Request.Headers["X-Forwarded-For"].ToString();
        }
        var sw = Stopwatch.StartNew();
        try
        {
            await next(context);
        }
        finally
        {
            sw.Stop();
            Console.WriteLine($"IP:{ip} Date:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} Path:{context.Request.Path} time:{sw.ElapsedMilliseconds} ms");
        }
    }
}
