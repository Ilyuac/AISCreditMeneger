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


            var loginController = new LoginPresinter(new LoginForm(),OpenGrandForm);
            loginController.Run();

           // Application.Run(new LoginForm());//�������� ���� � ����� ��� ��������� � ��������� ���� ��� �������� ����������.
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
