using System.Net;

namespace SnelStart.B2B.Client.Operations
{
    public class Response
    {
        public HttpStatusCode HttpStatusCode { internal set; get; }
    }

    public class Response<T> : Response
    {
        public T Result { get; internal set; }

    }
}