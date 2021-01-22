using System.IO;
using System.Net;

namespace FormForTest.Models
{
    class HttpReuest
    {
        public WebRequest WebRequest { get; set; }
        public HttpWebResponse Response { get { return (HttpWebResponse)WebRequest.GetResponse(); } }
        public Stream RespounseStream { get { return Response.GetResponseStream(); } }
        public Stream RequestStream { get { return WebRequest.GetRequestStream(); } }

        public HttpReuest(string urlSttring, Method method)
        {
            WebRequest = WebRequest.Create(urlSttring);
            WebRequest.Method = method.ToString();
            if (method == Method.POST)
            {
                WebRequest.ContentType = "application/json";
            }
        }
    }
}
