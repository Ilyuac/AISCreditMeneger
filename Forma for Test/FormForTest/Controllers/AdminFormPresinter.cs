using FormForTest.Models;
using FormForTest.UI;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FormForTest.Controllers
{
    class AdminFormPresinter : IAdminPresinter
    {
        private readonly IAdminForm View;

        public AdminFormPresinter(IAdminForm view)
        {
            View = view;

            View.RemoveUser += new Func<User, string>(RemoveUser);
            View.AddUser += new Func<User, string>(AddUser);
            View.UpdateUser += new Func<int, User, string>(UpdateUser);
        }

        public string AddUser(User user)
        {
            View.Users.Add(user);
            return UpdateDBAsync();
        }

        public string RemoveUser(User user)
        {
            View.Users.Remove(user);
            return UpdateDBAsync();
        }

        public string UpdateUser(int id, User newUser)
        {
            newUser.UserId = id;
            int index = View.Users.FindIndex(u => u.UserId == id);
            View.Users[index] = newUser;
            return UpdateDBAsync();
        }

        public void Run()
        {
            View.Show();
        }

        public void Close()
        {
            View.Close();
        } 

        private string UpdateDBAsync()
        {
           return Task<string>.Run(() =>
            {
                try
                {
                    using (var db = new ContextDB())
                    {
                        db.Users.UpdateRange(View.Users);

                    }
                    return "Successfyl update!!!";
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
            }).Result;
        }//подумать над заменой string на struct Message { string Herder, string Message, enum Type }
    }
}
