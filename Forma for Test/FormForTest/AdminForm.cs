using FormForTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormForTest
{
    public partial class AdminForm : Form
    {
        User User;
        public AdminForm(User user)
        {
            InitializeComponent();
            User = user;
        }
    }
}
