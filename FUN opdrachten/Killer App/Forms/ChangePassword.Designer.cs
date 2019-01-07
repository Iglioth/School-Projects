namespace Killer_App
{
    partial class ChangePassword
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
            this.TBOldPassword = new System.Windows.Forms.TextBox();
            this.BSubmit = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.LOldPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNewPassword = new System.Windows.Forms.TextBox();
            this.TBRepeatPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBOldPassword
            // 
            this.TBOldPassword.Location = new System.Drawing.Point(182, 139);
            this.TBOldPassword.Name = "TBOldPassword";
            this.TBOldPassword.Size = new System.Drawing.Size(100, 22);
            this.TBOldPassword.TabIndex = 0;
            // 
            // BSubmit
            // 
            this.BSubmit.Location = new System.Drawing.Point(121, 326);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(110, 44);
            this.BSubmit.TabIndex = 3;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = true;
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 0);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(57, 57);
            this.BHome.TabIndex = 4;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // LOldPassword
            // 
            this.LOldPassword.AutoSize = true;
            this.LOldPassword.Location = new System.Drawing.Point(12, 142);
            this.LOldPassword.Name = "LOldPassword";
            this.LOldPassword.Size = new System.Drawing.Size(99, 17);
            this.LOldPassword.TabIndex = 5;
            this.LOldPassword.Text = "Old Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repeat new password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Password:";
            // 
            // TBNewPassword
            // 
            this.TBNewPassword.Location = new System.Drawing.Point(182, 212);
            this.TBNewPassword.Name = "TBNewPassword";
            this.TBNewPassword.Size = new System.Drawing.Size(100, 22);
            this.TBNewPassword.TabIndex = 8;
            // 
            // TBRepeatPassword
            // 
            this.TBRepeatPassword.Location = new System.Drawing.Point(182, 265);
            this.TBRepeatPassword.Name = "TBRepeatPassword";
            this.TBRepeatPassword.Size = new System.Drawing.Size(100, 22);
            this.TBRepeatPassword.TabIndex = 9;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.TBRepeatPassword);
            this.Controls.Add(this.TBNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LOldPassword);
            this.Controls.Add(this.BHome);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.TBOldPassword);
            this.Name = "ChangePassword";
            this.Text = "Change password:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBOldPassword;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.Label LOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNewPassword;
        private System.Windows.Forms.TextBox TBRepeatPassword;
    }
}