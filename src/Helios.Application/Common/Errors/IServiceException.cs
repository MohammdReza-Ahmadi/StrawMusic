using System.Net;

namespace Helios.Application.Common.Errors
{
    public interface IServiceException
    {
        public HttpStatusCode StatusCode{get;}
        public string ErrorMessage {get;}
    }
}