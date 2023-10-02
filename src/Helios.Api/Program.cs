using Helios.Api.Filters;
using Helios.Api.Middleware;
using Helios.Application;
using Helios.Infrastructure;
var builder = WebApplication.CreateBuilder(args);
{
builder.Services.AddApplication()
.AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();
}


var app = builder.Build();
{

    //app.UseMiddleware<ErrorHandelingMiddleware>();
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}


