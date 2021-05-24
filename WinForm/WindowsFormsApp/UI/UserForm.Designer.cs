namespace WindowsFormsApp.UI
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBox = new System.Windows.Forms.GroupBox();
            this.mtBox_PhoneIn = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBox_SalaryIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBox_CarsIn = new System.Windows.Forms.ComboBox();
            this.cBox_MaterialStatusIn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox_RealtyIn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.tBox_FIOIn = new System.Windows.Forms.TextBox();
            this.cBox_GenderIn = new System.Windows.Forms.ComboBox();
            this.butPost = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRussian = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.tBox_SalaryOut = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cBox_CarsOut = new System.Windows.Forms.ComboBox();
            this.cBox_MaterialStatusOut = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cBox_RealtyOut = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tBox_FIOOut = new System.Windows.Forms.TextBox();
            this.cBox_GenderOut = new System.Windows.Forms.ComboBox();
            this.butFixed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxResult = new System.Windows.Forms.CheckBox();
            this.chBoxRecomendate = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.mtBox_PhoneOut = new System.Windows.Forms.MaskedTextBox();
            this.gBox.SuspendLayout();
            this.Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.mtBox_PhoneIn);
            this.gBox.Controls.Add(this.label7);
            this.gBox.Controls.Add(this.tBox_SalaryIn);
            this.gBox.Controls.Add(this.label6);
            this.gBox.Controls.Add(this.label5);
            this.gBox.Controls.Add(this.cBox_CarsIn);
            this.gBox.Controls.Add(this.cBox_MaterialStatusIn);
            this.gBox.Controls.Add(this.label4);
            this.gBox.Controls.Add(this.cBox_RealtyIn);
            this.gBox.Controls.Add(this.label3);
            this.gBox.Controls.Add(this.label2);
            this.gBox.Controls.Add(this.label1);
            this.gBox.Controls.Add(this.progBar);
            this.gBox.Controls.Add(this.tBox_FIOIn);
            this.gBox.Controls.Add(this.cBox_GenderIn);
            this.gBox.Controls.Add(this.butPost);
            this.gBox.Location = new System.Drawing.Point(10, 31);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(262, 250);
            this.gBox.TabIndex = 0;
            this.gBox.TabStop = false;
            this.gBox.Text = "Anketa";
            // 
            // mtBox_PhoneIn
            // 
            this.mtBox_PhoneIn.Location = new System.Drawing.Point(95, 176);
            this.mtBox_PhoneIn.Mask = "(999) 000-0000";
            this.mtBox_PhoneIn.Name = "mtBox_PhoneIn";
            this.mtBox_PhoneIn.Size = new System.Drawing.Size(154, 20);
            this.mtBox_PhoneIn.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Salary:";
            // 
            // tBox_SalaryIn
            // 
            this.tBox_SalaryIn.Location = new System.Drawing.Point(95, 152);
            this.tBox_SalaryIn.Name = "tBox_SalaryIn";
            this.tBox_SalaryIn.Size = new System.Drawing.Size(154, 20);
            this.tBox_SalaryIn.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cars:";
            // 
            // cBox_CarsIn
            // 
            this.cBox_CarsIn.FormattingEnabled = true;
            this.cBox_CarsIn.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cBox_CarsIn.Location = new System.Drawing.Point(95, 127);
            this.cBox_CarsIn.Name = "cBox_CarsIn";
            this.cBox_CarsIn.Size = new System.Drawing.Size(154, 21);
            this.cBox_CarsIn.TabIndex = 1;
            // 
            // cBox_MaterialStatusIn
            // 
            this.cBox_MaterialStatusIn.FormattingEnabled = true;
            this.cBox_MaterialStatusIn.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cBox_MaterialStatusIn.Location = new System.Drawing.Point(95, 101);
            this.cBox_MaterialStatusIn.Name = "cBox_MaterialStatusIn";
            this.cBox_MaterialStatusIn.Size = new System.Drawing.Size(154, 21);
            this.cBox_MaterialStatusIn.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marital_Status:";
            // 
            // cBox_RealtyIn
            // 
            this.cBox_RealtyIn.FormattingEnabled = true;
            this.cBox_RealtyIn.Items.AddRange(new object[] {
            "None",
            "House",
            "Apartment"});
            this.cBox_RealtyIn.Location = new System.Drawing.Point(95, 76);
            this.cBox_RealtyIn.Name = "cBox_RealtyIn";
            this.cBox_RealtyIn.Size = new System.Drawing.Size(154, 21);
            this.cBox_RealtyIn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Realty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FIO:";
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(18, 230);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(231, 9);
            this.progBar.TabIndex = 3;
            // 
            // tBox_FIOIn
            // 
            this.tBox_FIOIn.Location = new System.Drawing.Point(95, 26);
            this.tBox_FIOIn.Name = "tBox_FIOIn";
            this.tBox_FIOIn.Size = new System.Drawing.Size(154, 20);
            this.tBox_FIOIn.TabIndex = 2;
            // 
            // cBox_GenderIn
            // 
            this.cBox_GenderIn.FormattingEnabled = true;
            this.cBox_GenderIn.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cBox_GenderIn.Location = new System.Drawing.Point(95, 51);
            this.cBox_GenderIn.Name = "cBox_GenderIn";
            this.cBox_GenderIn.Size = new System.Drawing.Size(154, 21);
            this.cBox_GenderIn.TabIndex = 1;
            // 
            // butPost
            // 
            this.butPost.Location = new System.Drawing.Point(172, 202);
            this.butPost.Name = "butPost";
            this.butPost.Size = new System.Drawing.Size(76, 23);
            this.butPost.TabIndex = 0;
            this.butPost.Text = "PostAnket";
            this.butPost.UseVisualStyleBackColor = true;
            this.butPost.Click += new System.EventHandler(this.butPost_Click);
            // 
            // Menu
            // 
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSettings,
            this.toolStripUser,
            this.toolStripExit});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(551, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLanguage});
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(61, 20);
            this.toolStripSettings.Text = "Settings";
            // 
            // toolStripLanguage
            // 
            this.toolStripLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEnglish,
            this.toolStripRussian});
            this.toolStripLanguage.Name = "toolStripLanguage";
            this.toolStripLanguage.Size = new System.Drawing.Size(126, 22);
            this.toolStripLanguage.Text = "Language";
            // 
            // toolStripEnglish
            // 
            this.toolStripEnglish.Checked = true;
            this.toolStripEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripEnglish.Name = "toolStripEnglish";
            this.toolStripEnglish.Size = new System.Drawing.Size(119, 22);
            this.toolStripEnglish.Text = "English";
            // 
            // toolStripRussian
            // 
            this.toolStripRussian.Name = "toolStripRussian";
            this.toolStripRussian.Size = new System.Drawing.Size(119, 22);
            this.toolStripRussian.Text = "Русский";
            // 
            // toolStripUser
            // 
            this.toolStripUser.Name = "toolStripUser";
            this.toolStripUser.Size = new System.Drawing.Size(42, 20);
            this.toolStripUser.Text = "User";
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(38, 20);
            this.toolStripExit.Text = "Exit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Salary:";
            // 
            // tBox_SalaryOut
            // 
            this.tBox_SalaryOut.Enabled = false;
            this.tBox_SalaryOut.Location = new System.Drawing.Point(95, 152);
            this.tBox_SalaryOut.Name = "tBox_SalaryOut";
            this.tBox_SalaryOut.Size = new System.Drawing.Size(154, 20);
            this.tBox_SalaryOut.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cars:";
            // 
            // cBox_CarsOut
            // 
            this.cBox_CarsOut.Enabled = false;
            this.cBox_CarsOut.FormattingEnabled = true;
            this.cBox_CarsOut.Location = new System.Drawing.Point(95, 127);
            this.cBox_CarsOut.Name = "cBox_CarsOut";
            this.cBox_CarsOut.Size = new System.Drawing.Size(154, 21);
            this.cBox_CarsOut.TabIndex = 1;
            // 
            // cBox_MaterialStatusOut
            // 
            this.cBox_MaterialStatusOut.Enabled = false;
            this.cBox_MaterialStatusOut.FormattingEnabled = true;
            this.cBox_MaterialStatusOut.Location = new System.Drawing.Point(95, 101);
            this.cBox_MaterialStatusOut.Name = "cBox_MaterialStatusOut";
            this.cBox_MaterialStatusOut.Size = new System.Drawing.Size(154, 21);
            this.cBox_MaterialStatusOut.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Marital_Status:";
            // 
            // cBox_RealtyOut
            // 
            this.cBox_RealtyOut.Enabled = false;
            this.cBox_RealtyOut.FormattingEnabled = true;
            this.cBox_RealtyOut.Location = new System.Drawing.Point(95, 76);
            this.cBox_RealtyOut.Name = "cBox_RealtyOut";
            this.cBox_RealtyOut.Size = new System.Drawing.Size(154, 21);
            this.cBox_RealtyOut.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Realty:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Gender:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "FIO:";
            // 
            // tBox_FIOOut
            // 
            this.tBox_FIOOut.Enabled = false;
            this.tBox_FIOOut.Location = new System.Drawing.Point(95, 26);
            this.tBox_FIOOut.Name = "tBox_FIOOut";
            this.tBox_FIOOut.Size = new System.Drawing.Size(154, 20);
            this.tBox_FIOOut.TabIndex = 2;
            // 
            // cBox_GenderOut
            // 
            this.cBox_GenderOut.Enabled = false;
            this.cBox_GenderOut.FormattingEnabled = true;
            this.cBox_GenderOut.Location = new System.Drawing.Point(95, 51);
            this.cBox_GenderOut.Name = "cBox_GenderOut";
            this.cBox_GenderOut.Size = new System.Drawing.Size(154, 21);
            this.cBox_GenderOut.TabIndex = 1;
            // 
            // butFixed
            // 
            this.butFixed.Location = new System.Drawing.Point(172, 243);
            this.butFixed.Name = "butFixed";
            this.butFixed.Size = new System.Drawing.Size(76, 23);
            this.butFixed.TabIndex = 0;
            this.butFixed.Text = "Fixed Result";
            this.butFixed.UseVisualStyleBackColor = true;
            this.butFixed.Click += new System.EventHandler(this.butFixed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxResult);
            this.groupBox1.Controls.Add(this.chBoxRecomendate);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.mtBox_PhoneOut);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tBox_SalaryOut);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cBox_CarsOut);
            this.groupBox1.Controls.Add(this.cBox_MaterialStatusOut);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cBox_RealtyOut);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tBox_FIOOut);
            this.groupBox1.Controls.Add(this.cBox_GenderOut);
            this.groupBox1.Controls.Add(this.butFixed);
            this.groupBox1.Location = new System.Drawing.Point(278, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anketa";
            // 
            // chBoxResult
            // 
            this.chBoxResult.AutoSize = true;
            this.chBoxResult.Location = new System.Drawing.Point(165, 225);
            this.chBoxResult.Name = "chBoxResult";
            this.chBoxResult.Size = new System.Drawing.Size(15, 14);
            this.chBoxResult.TabIndex = 7;
            this.chBoxResult.UseVisualStyleBackColor = true;
            // 
            // chBoxRecomendate
            // 
            this.chBoxRecomendate.AutoSize = true;
            this.chBoxRecomendate.Enabled = false;
            this.chBoxRecomendate.Location = new System.Drawing.Point(165, 203);
            this.chBoxRecomendate.Name = "chBoxRecomendate";
            this.chBoxRecomendate.Size = new System.Drawing.Size(15, 14);
            this.chBoxRecomendate.TabIndex = 7;
            this.chBoxRecomendate.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Result:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Recomendate:";
            // 
            // mtBox_PhoneOut
            // 
            this.mtBox_PhoneOut.Enabled = false;
            this.mtBox_PhoneOut.Location = new System.Drawing.Point(95, 176);
            this.mtBox_PhoneOut.Mask = "(999) 000-0000";
            this.mtBox_PhoneOut.Name = "mtBox_PhoneOut";
            this.mtBox_PhoneOut.Size = new System.Drawing.Size(154, 20);
            this.mtBox_PhoneOut.TabIndex = 6;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.ComboBox cBox_RealtyIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.TextBox tBox_FIOIn;
        private System.Windows.Forms.ComboBox cBox_GenderIn;
        private System.Windows.Forms.Button butPost;
        private System.Windows.Forms.ComboBox cBox_MaterialStatusIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBox_CarsIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBox_SalaryIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripEnglish;
        private System.Windows.Forms.ToolStripMenuItem toolStripRussian;
        private System.Windows.Forms.ToolStripMenuItem toolStripUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBox_SalaryOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBox_CarsOut;
        private System.Windows.Forms.ComboBox cBox_MaterialStatusOut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBox_RealtyOut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBox_FIOOut;
        private System.Windows.Forms.ComboBox cBox_GenderOut;
        private System.Windows.Forms.Button butFixed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtBox_PhoneIn;
        private System.Windows.Forms.MaskedTextBox mtBox_PhoneOut;
        private System.Windows.Forms.CheckBox chBoxResult;
        private System.Windows.Forms.CheckBox chBoxRecomendate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}