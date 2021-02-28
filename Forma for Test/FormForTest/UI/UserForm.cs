using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormForTest.UI
{
    public partial class UserForm : Form, IUserForm
    {
        public Request Request => throw new NotImplementedException();

        public User User { get; private set; }

        public event Action PostRequest;
        public event Action GetRequest;

        public UserForm(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void butPost_Click(object sender, EventArgs e)
        {
            PostRequest();
        }
    }
}
