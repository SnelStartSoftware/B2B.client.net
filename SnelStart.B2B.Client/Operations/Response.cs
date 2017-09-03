using System.Net;

namespace SnelStart.B2B.Client.Operations
{
    public class Response
    {
        internal HttpStatusCode HttpStatusCode { set; get; }
        internal string ResponseBody { set; get; }
    }

    public class Response<T> : Response
    {
        public T Result { get; internal set; }

    }
}