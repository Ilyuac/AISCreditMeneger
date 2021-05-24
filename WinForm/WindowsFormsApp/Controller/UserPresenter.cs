using WindowsFormsApp.Models;
using WindowsFormsApp.UI;

namespace WindowsFormsApp.Controllers
{
    class UserPresenter : IPresenter
    {
        static string webPathBase = Properties.Settings.Default.WebPathConfig;
        IUserForm _userForm;
        IProviderDatabase _provider;

        public UserPresenter(IUserForm userForm)
        {
            _userForm = userForm;
            _provider = ProviderFactory.GetLinqToDbProvider();

            _userForm.PostRequest += PostRequest;
            _userForm.GetRequest += GetRequest;
            _userForm.InsertRequest += InsertAnket;
        }

        public void Close()
        {
            _userForm.Close();
        }

        public void Run()
        {
            _userForm.Show();
        }

        string PostRequest(string json)
        {
            HttpRequestController requestController = new HttpRequestController();
            string result = requestController.POST_HttpReuest(webPathBase + Properties.Settings.Default.WebPathUser, json);
            return result;
        }

        string GetRequest()
        {
            HttpRequestController requestController = new HttpRequestController();
            return requestController.GET_HttpReuest(webPathBase + Properties.Settings.Default.WebPathUser);
        }

        void InsertAnket(Request request)
        {
            _provider.AddRequests(request);
        }
    }
}
