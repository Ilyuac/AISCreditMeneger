using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormForTest.Controllers
{
    class UserController
    {
        public User GetUser { get; private set; }
        ContextDB DB;

        public UserController(User user)
        {
            GetUser = user;
        }

        public void Update(User user)
        {
            DB.Users.Update(user);
        }
    }
}
