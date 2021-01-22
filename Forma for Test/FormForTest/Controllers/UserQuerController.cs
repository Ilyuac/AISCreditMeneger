using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace FormForTest.Controllers
{
    class UserQuerController//переработать с учетом новых классов httprequest
    {
        public UserQuerController()
        {
            using(var client = new HttpClient())
            {
                client.PostAsJsonAsync(SettingsResourse.Path_API + "", OpenNNFile());//проверить
            }
        }
        public bool QuerUser(List<double> inputVector)
        {
            using (var client = new HttpClient())
            {
                //var result = client.get
            }
            return false;
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
