using FormForTest.Models;
using FormForTest.UI;
using System;
using System.Collections.Generic;

namespace FormForTest.Controllers
{
    class AdminFormPresinter : IAdminPresinter
    {
        IAdminForm _adminForm;
        IProviderDatabase _provider;

        public AdminFormPresinter(IAdminForm adminForm)
        {
            _adminForm = adminForm;
            _provider = ProviderFactory.GetLinqToDbProvider();

            _adminForm.GetUsers += new Func<List<User>>(_provider.GetAllUsers);
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
