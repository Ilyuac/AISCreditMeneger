using WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp.Controllers;

namespace WindowsFormsApp.UI
{
    public partial class UserForm : Form, IUserForm
    {
        public User User { get; private set; }

        public Request Request { get; set; }

        /// <summary>
        /// Запрос get
        /// </summary>
        public event Func<string> GetRequest;

        /// <summary>
        /// Запрос post.
        /// </summary>
        public event Func<string, string> PostRequest;
        public event Action<Request> InsertRequest;

        public UserForm(User user)
        {
            InitializeComponent();
            User = user;
        }

        public new void Show()
        {
            ShowDialog();
        }

        private void butPost_Click(object sender, EventArgs e)
        {
            Request = new Request();
            tBox_FIOOut.Text = Request.Name = tBox_FIOIn.Text;
            cBox_GenderOut.Text = Request.Gender = cBox_GenderIn.Text;
            cBox_RealtyOut.Text = Request.Realty = cBox_RealtyIn.Text;
            cBox_MaterialStatusOut.Text = Request.Marital_Status = cBox_MaterialStatusIn.Text;
            cBox_CarsOut.Text = Request.Car = cBox_CarsIn.Text;
            tBox_SalaryOut.Text = tBox_SalaryIn.Text;
            Request.Salary = Convert.ToInt32(tBox_SalaryIn.Text);
            mtBox_PhoneOut.Text = Request.Phone = mtBox_PhoneIn.Text;

            var json = ConverterController.ConvertAnketToJson(Request);
            var result = PostRequest(json);
            var resultObj = ConverterController.ConvertToObject<Request>(result);
            chBoxRecomendate.Checked = resultObj.Recomendate;
        }

        private void butFixed_Click(object sender, EventArgs e)
        {
            Request.Result = chBoxResult.Checked;

            InsertRequest(Request);
        }
    }
}
