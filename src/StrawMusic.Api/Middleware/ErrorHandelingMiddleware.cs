using System.Net;
using System.Text.Json;

namespace Helios.Api.Middleware;

public class ErrorHandelingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandelingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch(Exception ex)
        {
            await HandelExceptionAsync(context, ex);
        }
    }

    private static Task HandelExceptionAsync(HttpContext context,Exception exception)
    {
        var code = HttpStatusCode.InternalServerError; // 500 if unexpected
        var result = JsonSerializer.Serialize(new {error = "exception.Message"});
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;
        return context.Response.WriteAsync(result);
    }
}