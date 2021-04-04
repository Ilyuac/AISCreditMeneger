﻿using WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp.UI
{
    public partial class AdminForm : Form, IAdminForm
    {
        public event Action<User> AddUser;
        public event Action<User> RemoveUser;
        public event Func<int, User> UpdateUser;
        public event Func<string, string> GetRequest;
        public event Func<string, string, string> PostRequest;
        public event Func<List<User>> GetUsers;
        public event Action<Request> InsertRequest;

        List<User> Users { get; set; }
        public User User { get; }
        public Request Request { get; set; }

        public AdminForm(User user)
        {
            InitializeComponent();
            User = user ?? throw new ArgumentNullException(nameof(user));
        }

        public new void Close()
        {
            Application.Exit();
        }

        public new void Show()
        {
            ShowDialog();
            //Application.Run(this);
        }
         
        /// <summary>
        /// Загрузка в лист.
        /// </summary>
        private void LoadUsersList()
        {
            foreach (var item in Users)
            {
                lBoxUser.Items.Add(item.ToString());
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = tBoxLogin.Text;
            user.Password = tBoxPassword.Text;
            user.Name = tBoxName.Text;

            switch (cBoxRole.Text)
            {
                case "User": 
                    user.Role = Role.User.ToString();
                    break;
                case "Admin":
                    user.Role = Role.Admin.ToString();
                    break;
            }

            if (AddUser != null)
            {
                AddUser(user);
            }

            ClearUserAdd();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ClearUserAdd();
        }

        private void ClearUserAdd()
        {
            tBoxLogin.Text = null;
            tBoxName.Text = null;
            tBoxPassword.Text = null;
            cBoxRole.Text = null;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            if (GetUsers != null)
            {
                Users = GetUsers();
            }

            LoadUsersList();
        }
    }
}