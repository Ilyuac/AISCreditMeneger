using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FormForTest.Controllers
{
    class AdministratorQuerController
    {
        User User;
        string UrlStrCreate = "/ConfigGenerator";
        string UrlStrLern = "/ConfigGenerator/Lerning";
        HttpRequestController HttpRequest;
        ContextDB ContextDB;

        public AdministratorQuerController(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не варифицирован.", nameof(user));
            HttpRequest = new HttpRequestController();
            ContextDB = new ContextDB();
        }

        public string GetTopology()
        {
            return HttpRequest.GET_HttpReuest(UrlStrCreate+"/true");
        }
        public string GetNN()
        {
            return HttpRequest.GET_HttpReuest(UrlStrCreate+"/false");
        }
        public void CreateNewNN(string topologyJsonStr)
        {
            HttpRequest.POST_HttpReuest(UrlStrCreate,topologyJsonStr);
        }
        public void UpdateNN(string JsonStrNN)
        {
            HttpRequest.POST_HttpReuest(UrlStrCreate,JsonStrNN);
        }
        public void Lerning()
        {
            //Придумать как извлечь обучающую выборку.
            string json = CreateNewSelection();
            HttpRequest.POST_HttpReuest(UrlStrLern, json);
        }
        private string OpenFile(string path)
        {
            string result;
            using (var ReadStream = new StreamReader(path))
            {
                result = ReadStream.ReadToEnd();
            }

            return result;
        }
        public string CreateNewSelection()
        {
            List<Tuple<double, double[]>> Selection = new List<Tuple<double, double[]>>();



            return JsonSerlizebleController.ConvertToJsonString(Selection);
        }
        public void RegistrationNewUser(User user)
        {
            RegistrationAndLoginController registrationController = new RegistrationAndLoginController(ContextDB);
            registrationController.RegistrationNewUser(user);
        }
    }
}
