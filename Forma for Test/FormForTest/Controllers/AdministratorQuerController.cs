using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormForTest.Controllers
{
    class AdministratorQuerController
    {
        User User;
        string UrlStrCreate = "/ConfigGenerator";
        string UrlStrLern = "/ConfigGenerator/Lerning";
        HttpRequestController HttpRequest;

        public AdministratorQuerController(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не варифицирован.", nameof(user));
            HttpRequest = new HttpRequestController();
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
            //Придумать как извлечь  обучающую выборку.
        }
    }
}
