using FormForTest.Controllers;
using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FormForTest
{
    public partial class LoginForm : Form
    {
        RegistrationAndLoginController loginController;
        UserController UserController;
        public LoginForm()
        {
            InitializeComponent();

            loginController = new RegistrationAndLoginController(new ContextDB());
        }

        public User GetUser() { return UserController.GetUser; }
        private void ProgressBar()
        {
            Random random = new Random();
            DateTime endTime = DateTime.Now + TimeSpan.FromSeconds(5);
            int j = random.Next(0, 50);
            while (endTime>DateTime.Now)
            {
                for (int i = 0; i < j; i++)
                {
                    progBar.Value = i;
                }
                Thread.Sleep(2000);
                j = random.Next(j, 75);
            }
            if(progBar.Maximum > progBar.Value)
            {
                progBar.Value = 100;
            }
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            UserController = new UserController(loginController.LoginUser(tBoxLogin.Text, tBoxPassword.Text));
            ProgressBar();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
