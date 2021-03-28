using FormForTest.Models;
using FormForTest.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormForTest.Controllers
{
    class UserPresinter : IPresinter
    {
        public User GetUser { get; private set; }
        IConnect DB;
        IHttpRequest requestController; 

        private readonly IUserForm View;

        public UserPresinter(IUserForm userForm, IConnect connect)
        {
            DB = connect; 
            requestController = new HttpRequestController();
            GetUser = userForm.User;
            View = userForm;

            View.GetRequest += new Func<string, string>(requestController.GET_HttpReuest);
            View.PostRequest += new Func<string, string, string>(requestController.POST_HttpReuest);
        }

        public void Update(User user)
        {
            DB.Users.Update(user);
        }

        public void Run()
        {
            View.Show();
        }

        public void Close()
        {
            View.Close();
        }
    }
}
