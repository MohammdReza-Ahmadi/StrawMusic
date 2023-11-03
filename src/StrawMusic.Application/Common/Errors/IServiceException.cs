using System.Net;

namespace StrawMusic.Application.Common.Errors
{
    public interface IServiceException
    {
        public HttpStatusCode StatusCode{get;}
        public string ErrorMessage {get;}
    }
}