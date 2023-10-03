using Helios.Api.Errors;
using Helios.Api.Filters;
using Helios.Api.Middleware;
using Helios.Application;
using Helios.Infrastructure;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;
var builder = WebApplication.CreateBuilder(args);
{
builder.Services.AddApplication()
.AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory,HeliosProblemDetailsFactory>();
}


var app = builder.Build();
{

    //app.UseMiddleware<ErrorHandelingMiddleware>();
    app.UseExceptionHandler("/error");
    // app.Map("/error",(HttpContext httpContext)=>{
    //     Exception? exception = httpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
    // });
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}


