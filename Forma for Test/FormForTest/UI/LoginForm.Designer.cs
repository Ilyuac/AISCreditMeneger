namespace FormForTest.UI
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.butEnter = new System.Windows.Forms.Button();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.Location = new System.Drawing.Point(100, 12);
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(172, 23);
            this.tBoxLogin.TabIndex = 1;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(100, 51);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(172, 23);
            this.tBoxPassword.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(197, 95);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butEnter
            // 
            this.butEnter.Location = new System.Drawing.Point(12, 95);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(75, 23);
            this.butEnter.TabIndex = 7;
            this.butEnter.Text = "Enter";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 124);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(260, 16);
            this.progBar.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.butEnter);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.ProgressBar progBar;
    }
}