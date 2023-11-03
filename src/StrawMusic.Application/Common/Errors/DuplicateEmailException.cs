using System.Net;
using Helios.Application.Common.Errors;

namespace Helios.Application.Common;
public class DuplicateEmailException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMessage => "Email already exists.";
}
