using FormForTest.Models;
using System;
using System.Linq;

namespace FormForTest.Controllers
{
    class RegistrationAndLoginController
    {
        ContextDB DB;
        public RegistrationAndLoginController(ContextDB context)
        {
            DB = context ?? throw new ArgumentNullException();
        }
        public void RegistrationNewUser(User user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Login)&&!string.IsNullOrWhiteSpace(user.Name)&&!string.IsNullOrWhiteSpace(user.Password))
            {
                if (user.Login != "Admin" || user.Login != "Administrator" || user.Name != "Admin" || user.Name != "Administrator")
                {
                    if (user.Password.Length >= 8)
                    {
                        if (DB.Users.First(u => u.Login == user.Login) == null)
                        {
                            DB.Users.Add(user);
                        }
                        else
                        {
                            throw new Exception("Пользователь с таким логином уже существует измените логин.");
                        }
                    }
                    else
                    {
                        throw new Exception("Пароль должен быть 8 или более символов.");
                    }
                }
                else
                {
                    throw new Exception("Логин или имя не могут содержать служебные имена, например, Admin, Administrator.");
                }
            }
            else
            {
                throw new Exception("Нельзя зарегистрировать пустого пользователя.");
            }
        }
        public User LoginUser(string logiin, string password)
        {
            User user = DB.Users.First(u => u.Login == logiin);
            if(user!=null)
                if(user.Password==password)
                {
                    return user;
                }
            throw new Exception("Неверный логин или пароль.");
        }
    }
}
