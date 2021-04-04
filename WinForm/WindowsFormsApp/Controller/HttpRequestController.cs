using WindowsFormsApp.Models;
using WindowsFormsApp.UI;
using System;
using System.IO;

namespace WindowsFormsApp.Controllers
{
    /// <summary>
    /// Котероллер запросов.
    /// </summary>
    public class HttpRequestController : IHttpRequest
    {
        HttpReuest HttpReuest;

        /// <summary>
        /// Создание контроллера запросов.
        /// </summary>
        public HttpRequestController()
        {
        }

        /// <summary>
        /// GET запрос
        /// </summary>
        /// <param name="urlStr">Адрес</param>
        /// <returns></returns>
        public string GET_HttpReuest(string urlStr)
        {
            HttpReuest = new HttpReuest(urlStr, Method.GET);
            string result;
            using (var StreamRead = new StreamReader(HttpReuest.RespounseStream))
            {
                result = StreamRead.ReadToEnd();
            }

            return result;
        }

        /// <summary>
        /// POST запрос.
        /// </summary>
        /// <param name="urlStr">Адрес</param>
        /// <param name="jsonStr">Json дополнение</param>
        /// <returns></returns>
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
