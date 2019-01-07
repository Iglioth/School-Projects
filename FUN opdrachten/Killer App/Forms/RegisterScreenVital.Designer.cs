namespace Killer_App
{
    partial class RegisterScreenVitalB
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
            this.BHome = new System.Windows.Forms.Button();
            this.BRegisterVital = new System.Windows.Forms.Button();
            this.LUsername = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.LRepeatPassword = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LRepeatEmail = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBRepeatPassword = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBRepeatEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 0);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(59, 57);
            this.BHome.TabIndex = 0;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // BRegisterVital
            // 
            this.BRegisterVital.Location = new System.Drawing.Point(49, 385);
            this.BRegisterVital.Name = "BRegisterVital";
            this.BRegisterVital.Size = new System.Drawing.Size(252, 60);
            this.BRegisterVital.TabIndex = 1;
            this.BRegisterVital.Text = "Page 2 ->";
            this.BRegisterVital.UseVisualStyleBackColor = true;
            this.BRegisterVital.Click += new System.EventHandler(this.button2_Click);
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.Location = new System.Drawing.Point(13, 116);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(77, 17);
            this.LUsername.TabIndex = 2;
            this.LUsername.Text = "Username:";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(13, 167);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(73, 17);
            this.LPassword.TabIndex = 3;
            this.LPassword.Text = "Password:";
            // 
            // LRepeatPassword
            // 
            this.LRepeatPassword.AutoSize = true;
            this.LRepeatPassword.Location = new System.Drawing.Point(13, 220);
            this.LRepeatPassword.Name = "LRepeatPassword";
            this.LRepeatPassword.Size = new System.Drawing.Size(122, 17);
            this.LRepeatPassword.TabIndex = 4;
            this.LRepeatPassword.Text = "Repeat password:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(13, 263);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(46, 17);
            this.LEmail.TabIndex = 5;
            this.LEmail.Text = "Email:";
            // 
            // LRepeatEmail
            // 
            this.LRepeatEmail.AutoSize = true;
            this.LRepeatEmail.Location = new System.Drawing.Point(13, 307);
            this.LRepeatEmail.Name = "LRepeatEmail";
            this.LRepeatEmail.Size = new System.Drawing.Size(95, 17);
            this.LRepeatEmail.TabIndex = 6;
            this.LRepeatEmail.Text = "Repeat email:";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(143, 113);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(100, 22);
            this.TBUsername.TabIndex = 7;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(143, 164);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 22);
            this.TBPassword.TabIndex = 8;
            // 
            // TBRepeatPassword
            // 
            this.TBRepeatPassword.Location = new System.Drawing.Point(143, 217);
            this.TBRepeatPassword.Name = "TBRepeatPassword";
            this.TBRepeatPassword.Size = new System.Drawing.Size(100, 22);
            this.TBRepeatPassword.TabIndex = 9;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(143, 260);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 22);
            this.TBEmail.TabIndex = 10;
            // 
            // TBRepeatEmail
            // 
            this.TBRepeatEmail.Location = new System.Drawing.Point(143, 304);
            this.TBRepeatEmail.Name = "TBRepeatEmail";
            this.TBRepeatEmail.Size = new System.Drawing.Size(100, 22);
            this.TBRepeatEmail.TabIndex = 11;
            this.TBRepeatEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // RegisterScreenVitalB
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
            this.Controls.Add(this.BRegisterVital);
            this.Controls.Add(this.BHome);
            this.Name = "RegisterScreenVitalB";
            this.Text = "RegisterScreenVital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.Button BRegisterVital;
        private System.Windows.Forms.Label LUsername;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Label LRepeatPassword;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LRepeatEmail;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBRepeatPassword;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBRepeatEmail;
    }
}