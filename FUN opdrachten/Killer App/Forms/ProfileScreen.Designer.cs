namespace Killer_App
{
    partial class ProfileScreen
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
            this.BProfile = new System.Windows.Forms.Button();
            this.BToday = new System.Windows.Forms.Button();
            this.BData = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BHomeUpperLeft = new System.Windows.Forms.Button();
            this.LUsername = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.BChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(245, 609);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(97, 53);
            this.BProfile.TabIndex = 18;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            // 
            // BToday
            // 
            this.BToday.Location = new System.Drawing.Point(158, 609);
            this.BToday.Name = "BToday";
            this.BToday.Size = new System.Drawing.Size(91, 53);
            this.BToday.TabIndex = 17;
            this.BToday.Text = "Today";
            this.BToday.UseVisualStyleBackColor = true;
            // 
            // BData
            // 
            this.BData.Location = new System.Drawing.Point(82, 609);
            this.BData.Name = "BData";
            this.BData.Size = new System.Drawing.Size(80, 53);
            this.BData.TabIndex = 16;
            this.BData.Text = "Data";
            this.BData.UseVisualStyleBackColor = true;
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 609);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(85, 53);
            this.BHome.TabIndex = 15;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 109);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // BHomeUpperLeft
            // 
            this.BHomeUpperLeft.Location = new System.Drawing.Point(0, -2);
            this.BHomeUpperLeft.Name = "BHomeUpperLeft";
            this.BHomeUpperLeft.Size = new System.Drawing.Size(68, 45);
            this.BHomeUpperLeft.TabIndex = 20;
            this.BHomeUpperLeft.Text = "Home";
            this.BHomeUpperLeft.UseVisualStyleBackColor = true;
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.Location = new System.Drawing.Point(59, 208);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(77, 17);
            this.LUsername.TabIndex = 21;
            this.LUsername.Text = "Username:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(59, 284);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(42, 17);
            this.LEmail.TabIndex = 22;
            this.LEmail.Text = "Email";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(59, 248);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(73, 17);
            this.LPassword.TabIndex = 23;
            this.LPassword.Text = "Password:";
            // 
            // BChangePassword
            // 
            this.BChangePassword.Location = new System.Drawing.Point(62, 331);
            this.BChangePassword.Name = "BChangePassword";
            this.BChangePassword.Size = new System.Drawing.Size(142, 30);
            this.BChangePassword.TabIndex = 24;
            this.BChangePassword.Text = "Change Password";
            this.BChangePassword.UseVisualStyleBackColor = true;
            // 
            // ProfileScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.BChangePassword);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LUsername);
            this.Controls.Add(this.BHomeUpperLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.BToday);
            this.Controls.Add(this.BData);
            this.Controls.Add(this.BHome);
            this.Name = "ProfileScreen";
            this.Text = "ProfileScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button BToday;
        private System.Windows.Forms.Button BData;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BHomeUpperLeft;
        private System.Windows.Forms.Label LUsername;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Button BChangePassword;
    }
}