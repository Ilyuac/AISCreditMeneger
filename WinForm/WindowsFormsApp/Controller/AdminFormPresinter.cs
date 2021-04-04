using WindowsFormsApp.Models;
using WindowsFormsApp.UI;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp.Controllers
{
    class AdminFormPresinter : IAdminPresenter
    {
        IAdminForm _adminForm;
        IProviderDatabase _provider;

        public AdminFormPresinter(IAdminForm adminForm)
        {        
            _adminForm = adminForm;
            _provider = ProviderFactory.GetLinqToDbProvider();

            _adminForm.GetUsers += new Func<List<User>>(_provider.GetAllUsers);
            _adminForm.RemoveUser += new Action<User>(RemoveUser);
            _adminForm.AddUser += new Action<User>(AddUser);
        }

        public void AddUser(User user)
        {
            _provider.AddUser(user);
        }

        public void Close()
        {
            _adminForm.Close();
        }

        public void RemoveUser(User user)
        {
            _provider.RemoveUser(user);
        }

        public void Run()
        {
            _adminForm.Show();
        }

        public void UpdateUser(int id, User newUser)
        {
            newUser.UserId = id;
            _provider.UpdateUser(newUser);
        }
    }
}
