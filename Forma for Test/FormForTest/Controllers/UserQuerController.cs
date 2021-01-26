using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FormForTest.Controllers
{
    class UserQuerController
    {
        ContextDB ContextDB;
        User User;
        string UrlStr="/NeuronNetwork";
        HttpRequestController HttpRequest;
        public UserQuerController(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не варифицирован.",nameof(user));
            HttpRequest = new HttpRequestController();
            ContextDB = new ContextDB();

            string json = OpenNNFile();
            if (!string.IsNullOrWhiteSpace(json))
                HttpRequest.POST_HttpReuest(Properties.SettingsResourse.Path_API+UrlStr, json);
            else
                throw new Exception("Файл с настройками нейронной сети был пуст. Обратитесь к администратору.");
        }
        public bool QuerUser(string url, List<double> inputVector)
        {
            if (inputVector != null)
            {
                string json = JsonSerlizebleController.ConvertToJsonString(inputVector);
                var result = HttpRequest.POST_HttpReuest(url, json);

                if (Convert.ToDouble(Properties.SettingsResourse.Yes) >= Convert.ToDouble(result))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("inputVector был null.");
            }
        }
        private string OpenNNFile()
        {
            using (var stream = new StreamReader(Properties.SettingsResourse.Path_NN))
            {
                return stream.ReadToEnd();
            }
        }
        public void CreateNewRecordingLogbook(Request request, bool recomendate, bool result)
        {
            Logbook logbook = new Logbook();
            logbook.RecomendateResult = recomendate;
            logbook.Result = result;
            logbook.Request = request;
            logbook.User = User;

            ContextDB.Logbooks.Add(logbook);
            ContextDB.Requests.First(r=>r.RequestId == request.RequestId).Logbooks.Add(logbook);
            ContextDB.SaveChanges();
        }
        public void CreateRequest(Request request)
        {
            ContextDB.Requests.Add(request);
            ContextDB.SaveChanges();
        }
    }
}
