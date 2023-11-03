using System.Net;
using StrawMusic.Application.Common.Errors;

namespace StrawMusic.Application.Common;
public class DuplicateEmailException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMessage => "Email already exists.";
}
