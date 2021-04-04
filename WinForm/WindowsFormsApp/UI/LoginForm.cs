using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.UI
{
    public partial class LoginForm : Form, ILogin
    {

        public event Func<string, string, User> Login;
        public event Action<User> Logged_in;
        public event Action Clossed;
        User User { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        public void ShowError(string mes)
        {
            MessageBox.Show(mes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public new void Show()
        {
            ShowDialog();
            // Application.Run(this);//!!
        }

        //public new void Close()
        //{
        //    Dispose();
        //}

        private void butEnter_Click(object sender, EventArgs e)
        {
            // ProgressBar();

            User = Login(tBoxLogin.Text, tBoxPassword.Text);
            Clossed();
            Logged_in(User);
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
