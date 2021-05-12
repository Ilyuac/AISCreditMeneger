using FormForTest.Models;
using FormForTest.UI;
using FormForTest.Controllers;
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


            var loginPresinter = new LoginPresinter(new LoginForm(), OpenGrandForm);
            loginPresinter.Run();

           // Application.Run(new LoginForm());//поискать инфу в инете как закрывать и открывать окна без закрытия приложения.
        }

        private static void OpenGrandForm(User user)
        {
            switch (user.Role)
            {
                case Role.User: 
                    var userPresinter = new UserPresinter(new UserForm(user), new ContextDB());
                    userPresinter.Run();
                    break;
                case Role.Admin:
                    var adminPresinter = new AdminFormPresinter(new AdminForm(user));
                    adminPresinter.Run();
                    break;
            }
        }
    }
}
