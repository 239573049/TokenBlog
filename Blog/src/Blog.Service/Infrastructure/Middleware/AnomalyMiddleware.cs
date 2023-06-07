using System;

namespace Blog.Service.Infrastructure.Middleware;

public class AnomalyMiddleware : IMiddleware
{
    private readonly ILogger<AnomalyMiddleware> _logger;

    public AnomalyMiddleware(ILogger<AnomalyMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (UserFriendlyException exception) // 拦截UserFriendlyException异常返回指定模型Message
        {
            context.Response.StatusCode = 400;
            await context.Response.WriteAsJsonAsync(new
            {
                message = exception.Message
            });
        }
        catch (UnauthorizedAccessException) // 拦击UnauthorizedAccessException异常返回401
        {
            context.Response.StatusCode = 401;
        }
        catch (Exception ex)// 拦截其他异常返回500
        {
            _logger.LogError(ex, "请求发生错误");
            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync(new
            {
                message = "服务器发生错误"
            });
        }
    }
}
