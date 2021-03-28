using FormForTest.Models;
using FormForTest.UI;
using System;
using System.Linq;

namespace FormForTest.Controllers
{
    class LoginPresinter : IPresinter
    {
        private readonly ILogin View;
        IProviderDatabase _provider;

        public LoginPresinter(ILogin view, Action<User> action)
        {
            View = view;
            _provider = ProviderFactory.GetLinqToDbProvider();

            View.Login += new Func<string, string, User>(Login);
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

        private User Login(string login, string password)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(login))
                {
                    throw new ArgumentNullException(nameof(login), "Аргумент login был null.");
                }
                if(string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentNullException(nameof(password), "Аргумент password был null.");
                }

                return _provider.GetUser(login, password);
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
