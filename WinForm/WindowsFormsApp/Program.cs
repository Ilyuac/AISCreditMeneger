using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Controllers;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ScreanSeaver startScreen = new ScreanSeaver();
            DateTime time = DateTime.Now + TimeSpan.FromSeconds(5);
            startScreen.Show();

            while (time > DateTime.Now)
            {
                Application.DoEvents();
            }

            startScreen.Close();
            startScreen.Dispose();

            var loginPresinter = new LoginPresinter(new LoginForm(), OpenGrandForm);
            loginPresinter.Run();

            // Application.Run(new Form1());
        }

        private static void OpenGrandForm(User user)
        {
            switch (user.Role)
            {
                case "User":
                    var userPresinter = new UserPresenter(new UserForm(user));
                    userPresinter.Run();
                    break;
                case "Admin":
                    var adminPresinter = new AdminFormPresinter(new AdminForm(user));
                    adminPresinter.Run();
                    break;
            }
        }
    }
}
