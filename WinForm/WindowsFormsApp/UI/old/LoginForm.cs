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

namespace FormForTest.UI
{
    
    public partial class LoginForm : Form, ILogin
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public User User { get; private set; }

        public event Action<User> Logged_in;
        public event Func<string, string, User> Login;
        public event Action Clossed;

        public void ShowError(string mes)
        {
            MessageBox.Show(mes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public new void Show()
        {
            ShowDialog();
           // Application.Run(this);//!!
        }

        public new void Close()
        {
            Dispose();
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            // ProgressBar();

            User = Login(tBoxLogin.Text, tBoxPassword.Text);
            Logged_in(User);
            Clossed();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
