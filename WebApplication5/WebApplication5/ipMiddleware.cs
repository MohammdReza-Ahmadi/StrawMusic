using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication5
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ipMiddleware
    {
        private readonly RequestDelegate _next;

        public ipMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var a = httpContext.Request.Headers["User-Agent"];
            var item = httpContext.Connection.RemoteIpAddress.ToString();
            await _next(httpContext);
            if (httpContext.Request.Path.ToString().ToLower().Contains("/content"))
            {
                await httpContext.Response.WriteAsync("iiiiiiiiieeeeeeee");
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ipMiddlewareExtensions
    {
        public static IApplicationBuilder UseipMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ipMiddleware>();
        }
    }
}
