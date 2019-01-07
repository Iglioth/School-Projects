namespace Killer_App
{
    partial class RegisterScreenPersonal
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
            this.LFirstName = new System.Windows.Forms.Label();
            this.LLastName = new System.Windows.Forms.Label();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.DTPBirth = new System.Windows.Forms.DateTimePicker();
            this.LDateOfBirth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RBGenderMale = new System.Windows.Forms.RadioButton();
            this.RBGenderFemale = new System.Windows.Forms.RadioButton();
            this.BCreateAccount = new System.Windows.Forms.Button();
            this.TBRepeatEmail = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBRepeatPassword = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.LRepeatEmail = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LRepeatPassword = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.LUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LFirstName
            // 
            this.LFirstName.AutoSize = true;
            this.LFirstName.Location = new System.Drawing.Point(48, 254);
            this.LFirstName.Name = "LFirstName";
            this.LFirstName.Size = new System.Drawing.Size(78, 17);
            this.LFirstName.TabIndex = 1;
            this.LFirstName.Text = "First name:";
            // 
            // LLastName
            // 
            this.LLastName.AutoSize = true;
            this.LLastName.Location = new System.Drawing.Point(48, 294);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(78, 17);
            this.LLastName.TabIndex = 2;
            this.LLastName.Text = "Last name:";
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(178, 251);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(100, 22);
            this.TBFirstName.TabIndex = 3;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(178, 291);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(100, 22);
            this.TBLastName.TabIndex = 4;
            // 
            // DTPBirth
            // 
            this.DTPBirth.Location = new System.Drawing.Point(161, 331);
            this.DTPBirth.Name = "DTPBirth";
            this.DTPBirth.Size = new System.Drawing.Size(169, 22);
            this.DTPBirth.TabIndex = 5;
            this.DTPBirth.Value = new System.DateTime(2018, 12, 17, 0, 0, 0, 0);
            // 
            // LDateOfBirth
            // 
            this.LDateOfBirth.AutoSize = true;
            this.LDateOfBirth.Location = new System.Drawing.Point(48, 336);
            this.LDateOfBirth.Name = "LDateOfBirth";
            this.LDateOfBirth.Size = new System.Drawing.Size(90, 17);
            this.LDateOfBirth.TabIndex = 6;
            this.LDateOfBirth.Text = "Date of birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gender:";
            // 
            // RBGenderMale
            // 
            this.RBGenderMale.AutoSize = true;
            this.RBGenderMale.Location = new System.Drawing.Point(91, 424);
            this.RBGenderMale.Name = "RBGenderMale";
            this.RBGenderMale.Size = new System.Drawing.Size(59, 21);
            this.RBGenderMale.TabIndex = 8;
            this.RBGenderMale.TabStop = true;
            this.RBGenderMale.Text = "Male";
            this.RBGenderMale.UseVisualStyleBackColor = true;
            // 
            // RBGenderFemale
            // 
            this.RBGenderFemale.AutoSize = true;
            this.RBGenderFemale.Location = new System.Drawing.Point(178, 424);
            this.RBGenderFemale.Name = "RBGenderFemale";
            this.RBGenderFemale.Size = new System.Drawing.Size(75, 21);
            this.RBGenderFemale.TabIndex = 9;
            this.RBGenderFemale.TabStop = true;
            this.RBGenderFemale.Text = "Female";
            this.RBGenderFemale.UseVisualStyleBackColor = true;
            // 
            // BCreateAccount
            // 
            this.BCreateAccount.Location = new System.Drawing.Point(62, 511);
            this.BCreateAccount.Name = "BCreateAccount";
            this.BCreateAccount.Size = new System.Drawing.Size(199, 63);
            this.BCreateAccount.TabIndex = 10;
            this.BCreateAccount.Text = "Create Account";
            this.BCreateAccount.UseVisualStyleBackColor = true;
            this.BCreateAccount.Click += new System.EventHandler(this.BCreateAccount_Click);
            // 
            // TBRepeatEmail
            // 
            this.TBRepeatEmail.Location = new System.Drawing.Point(178, 203);
            this.TBRepeatEmail.Name = "TBRepeatEmail";
            this.TBRepeatEmail.Size = new System.Drawing.Size(100, 22);
            this.TBRepeatEmail.TabIndex = 21;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(178, 159);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 22);
            this.TBEmail.TabIndex = 20;
            // 
            // TBRepeatPassword
            // 
            this.TBRepeatPassword.Location = new System.Drawing.Point(178, 116);
            this.TBRepeatPassword.Name = "TBRepeatPassword";
            this.TBRepeatPassword.Size = new System.Drawing.Size(100, 22);
            this.TBRepeatPassword.TabIndex = 19;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(178, 63);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 22);
            this.TBPassword.TabIndex = 18;
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(178, 12);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(100, 22);
            this.TBUsername.TabIndex = 17;
            // 
            // LRepeatEmail
            // 
            this.LRepeatEmail.AutoSize = true;
            this.LRepeatEmail.Location = new System.Drawing.Point(48, 206);
            this.LRepeatEmail.Name = "LRepeatEmail";
            this.LRepeatEmail.Size = new System.Drawing.Size(95, 17);
            this.LRepeatEmail.TabIndex = 16;
            this.LRepeatEmail.Text = "Repeat email:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(48, 162);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(46, 17);
            this.LEmail.TabIndex = 15;
            this.LEmail.Text = "Email:";
            // 
            // LRepeatPassword
            // 
            this.LRepeatPassword.AutoSize = true;
            this.LRepeatPassword.Location = new System.Drawing.Point(48, 119);
            this.LRepeatPassword.Name = "LRepeatPassword";
            this.LRepeatPassword.Size = new System.Drawing.Size(122, 17);
            this.LRepeatPassword.TabIndex = 14;
            this.LRepeatPassword.Text = "Repeat password:";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(48, 66);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(73, 17);
            this.LPassword.TabIndex = 13;
            this.LPassword.Text = "Password:";
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.Location = new System.Drawing.Point(48, 15);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(77, 17);
            this.LUsername.TabIndex = 12;
            this.LUsername.Text = "Username:";
            // 
            // RegisterScreenPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.TBRepeatEmail);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBRepeatPassword);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.LRepeatEmail);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LRepeatPassword);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LUsername);
            this.Controls.Add(this.BCreateAccount);
            this.Controls.Add(this.RBGenderFemale);
            this.Controls.Add(this.RBGenderMale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LDateOfBirth);
            this.Controls.Add(this.DTPBirth);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.LLastName);
            this.Controls.Add(this.LFirstName);
            this.Name = "RegisterScreenPersonal";
            this.Text = "RegisterScreenPersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LFirstName;
        private System.Windows.Forms.Label LLastName;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.DateTimePicker DTPBirth;
        private System.Windows.Forms.Label LDateOfBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBGenderMale;
        private System.Windows.Forms.RadioButton RBGenderFemale;
        private System.Windows.Forms.Button BCreateAccount;
        private System.Windows.Forms.TextBox TBRepeatEmail;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBRepeatPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Label LRepeatEmail;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LRepeatPassword;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Label LUsername;
    }
}