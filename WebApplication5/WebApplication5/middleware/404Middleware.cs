using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class _404Middleware
    {
        private readonly RequestDelegate _next;

        public _404Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _next(httpContext);
            if (httpContext.Request.Headers["User-agent"].Any(p => p.Contains("chrome")))
            {
               httpContext.Response.StatusCode = 404;
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class _404MiddlewareExtensions
    {
        public static IApplicationBuilder Use_404Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<_404Middleware>();
        }
    }
}
