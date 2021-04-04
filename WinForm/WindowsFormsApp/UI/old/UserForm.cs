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
        public User User { get; private set; }

        public Request Request => throw new NotImplementedException();

        /// <summary>
        /// Запрос get
        /// </summary>
        public event Func<string, string> GetRequest;

        /// <summary>
        /// Запрос post.
        /// </summary>
        public event Func<string, string, string> PostRequest;

        public UserForm(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void butPost_Click(object sender, EventArgs e)
        {
            PostRequest("", "");//!
        }
    }
}
