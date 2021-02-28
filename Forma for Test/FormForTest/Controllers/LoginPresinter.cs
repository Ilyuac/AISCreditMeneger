using FormForTest.Models;
using FormForTest.UI;
using System;
using System.Linq;

namespace FormForTest.Controllers
{
    class LoginPresinter : IPresinter
    {
        private readonly ILogin View;

        public LoginPresinter(ILogin view, Action<User> action)
        {
            View = view;

            View.Login += new Func<User>(Login);
            View.Logged_in += new Action<User>(action);
            View.Clossed += new Action(Close);
        }

        public void Close()
        {
            View.Close();
        }

        public void Run()
        {
            View.Show();
        }

        private User Login()
        {
            try
            {
                if(string.IsNullOrWhiteSpace(View.Username))
                {
                    throw new ArgumentNullException(nameof(View.Username), "Аргумент View.Username был null.");
                }
                if(string.IsNullOrWhiteSpace(View.Password))
                {
                    throw new ArgumentNullException(nameof(View.Password), "Аргумент View.Password был null.");
                }

                using (var db = new ContextDB())
                {
                    return db.Users.FirstOrDefault(u => u.Login == View.Username && u.Password == View.Password);
                }
            }
            catch(ArgumentNullException ex)
            {
                View.ShowError(ex.Message);
                return null;
            }
            catch(Exception ex)
            {
                View.ShowError(ex.Message);
                return null;
            }
        }

        //private void ProgressBar(ProgressBar progress)
        //{
        //    Random random = new Random();
        //    DateTime endTime = DateTime.Now + TimeSpan.FromSeconds(5);
        //    int j = random.Next(0, 50);
        //    while (endTime > DateTime.Now)
        //    {
        //        for (int i = 0; i < j; i++)
        //        {
        //            progress.Value = i;
        //        }
        //        Thread.Sleep(2000);
        //        j = random.Next(j, 75);
        //    }
        //    if (progress.Maximum > progress.Value)
        //    {
        //        progress.Value = 100;
        //    }
        //}
    }
}
