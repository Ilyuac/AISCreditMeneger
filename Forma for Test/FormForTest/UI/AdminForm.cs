using FormForTest.Models;
using FormForTest.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormForTest
{
    public partial class AdminForm : Form, IAdminForm
    {
        public event Action PostRequest;
        public event Action GetRequest;
        public event Func<User, string> AddUser;
        public event Func<User, string> RemoveUser;
        public event Func<int, User, string> UpdateUser;

        public List<User> Users { get; set; }
        public User User { get; }
        public Request Request { get; set; }
        public AdminForm(User user)
        {
            InitializeComponent();
            User = user ?? throw new ArgumentNullException(nameof(user));
        }
    }
}
