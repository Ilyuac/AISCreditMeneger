using FormForTest.Controllers;
using FormForTest.Models;
using System;
using System.Windows.Forms;

namespace FormForTest
{
    public partial class AboutUser : UserControl
    {
        public User User;
        UI.IUserForm _userForm { get; set; }

        public AboutUser(UI.IUserForm userForm)
        {
            //User = user ?? throw new ArgumentNullException(nameof(user));
            User = new User();
            InitializeComponent();
            _userForm = userForm ?? throw new ArgumentNullException(nameof(userForm), "Была создана в пустой форме.");

            cBoxRole.DataSource = new object[] { Role.Admin, Role.User };
            Cancelation();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (tBoxRepeatPassword.Text == tBoxPassword.Text)
            {
                User updateUser = new User();
                updateUser.Name = tBoxName.Text;
                updateUser.Login = tBoxLogin.Text;
                updateUser.Password = tBoxPassword.Text;
                updateUser.Role = cBoxRole.SelectedItem.ToString();
                UserPresinter userController = new UserPresinter(_userForm);
                userController.Update(updateUser);
            }
            else
            {
                throw new Exception("Поля Password и Repeat Password должны совпадать.");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Cancelation();
        }

        private void Cancelation()
        {
            cBoxRole.Enabled = false;
            butCancel.Enabled = false;
            butUpdate.Enabled = false;
            tBoxName.Text = User.Name;
            tBoxLogin.Text = User.Login;
            tBoxPassword.Text = User.Password;
            cBoxRole.Text = User.Role.ToString();
        }

        private void TextChanged(object sender, EventArgs e)
        {

            butCancel.Enabled = true;
            butUpdate.Enabled = true;
        }
    }
}
