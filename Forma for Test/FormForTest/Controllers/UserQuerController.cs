using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace FormForTest.Controllers
{
    class UserQuerController
    {
        User User;
        string UrlStr="/NeuronNetwork";
        HttpRequestController HttpRequest;
        public UserQuerController(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не варифицирован.",nameof(user));
            HttpRequest = new HttpRequestController();

            string json = OpenNNFile();
            if (!string.IsNullOrWhiteSpace(json))
                HttpRequest.POST_HttpReuest(SettingsResourse.Path_API+UrlStr, json);
            else
                throw new Exception("Файл с настройками нейронной сети был пуст. Обратитесь к администратору.");
        }

        public bool QuerUser(string url, List<double> inputVector)
        {
            if (inputVector != null)
            {
                string json = JsonSerlizebleController.ConvertToJsonString(inputVector);
                var result = HttpRequest.POST_HttpReuest(url, json);

                if (Convert.ToDouble(SettingsResourse.Yes) >= Convert.ToDouble(result))
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
            using (var stream = new StreamReader(SettingsResourse.Path_NN))
            {
                return stream.ReadToEnd();
            }
        }
    }
}
