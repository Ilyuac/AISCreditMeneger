using FormForTest.Models;
using System.IO;

namespace FormForTest.Controllers
{
    class HttpRequestController
    {
        HttpReuest HttpReuest;

        public string GET_HttpReuest(string urlStr)
        {
            HttpReuest = new HttpReuest(urlStr,Method.GET);
            string result;
            using (var StreamRead = new StreamReader(HttpReuest.RespounseStream))
            {
                result = StreamRead.ReadToEnd();
            }

            return result;
        }

        public string POST_HttpReuest(string urlStr, string jsonStr)
        {
            HttpReuest = new HttpReuest(urlStr, Method.POST);
            string result;
            using (var StreamWrite = new StreamWriter(HttpReuest.RequestStream))
            {
                StreamWrite.Write(jsonStr);
                StreamWrite.Flush();
                StreamWrite.Close();

                using (var StreamRead = new StreamReader(HttpReuest.RespounseStream))
                {
                    result = StreamRead.ReadToEnd();
                }
            }

            return result;
        }
    }
}
