using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormForTest
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ScreanSeaver startScreen = new ScreanSeaver();
            DateTime time = DateTime.Now + TimeSpan.FromSeconds(5);
            startScreen.Show();
            while (time>DateTime.Now)
            {
                Application.DoEvents();
            }
            startScreen.Close();
            startScreen.Dispose();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            OpenGrandForm(loginForm.GetUser());
            loginForm.Close();
            loginForm.Dispose();

           // Application.Run(new LoginForm());//поискать инфу в инете как закрывать и открывать окна без закрытия приложения.
        }

        private static void OpenGrandForm(User user)
        {
            switch (user.Role)
            {
                case Role.User: Application.Run(new UserForm(user));
                    break;
                case Role.Admin: Application.Run(new AdminForm(user));
                    break;
            }
        }
    }
}
