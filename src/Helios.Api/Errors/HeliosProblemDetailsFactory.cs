using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;

namespace Helios.Api.Errors;

// public class HeliosProblemDetailsFactory : ProblemDetailsFactory
// {
//     private readonly ApiBehaviorOptions _options;

//     public HeliosProblemDetailsFactory(IOptions<ApiBehaviorOptions> options)
//     {
//         _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
//     }

//     // public override ProblemDetails CreateProblemDetails(HttpContext httpContext, int? statusCode = null, string? title = null, string? type = null, string? detail = null, string? instance = null)
//     // {
//     //    statusCode ??=500;

//     //    var ProblemDetails = new ProblemDetails
//     //    {
//     //     Status = statusCode,
//     //     Title = title,


//     //    }
//     // }

//     public override ValidationProblemDetails CreateValidationProblemDetails(HttpContext httpContext, ModelStateDictionary modelStateDictionary, int? statusCode = null, string? title = null, string? type = null, string? detail = null, string? instance = null)
//     {
//         throw new NotImplementedException();
//     }
// }