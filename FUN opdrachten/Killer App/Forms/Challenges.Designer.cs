namespace Killer_App
{
    partial class FChallenges
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
            this.BHomeUpperLeft = new System.Windows.Forms.Button();
            this.LBChallenges = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(245, 610);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(97, 53);
            this.BProfile.TabIndex = 22;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            // 
            // BToday
            // 
            this.BToday.Location = new System.Drawing.Point(158, 610);
            this.BToday.Name = "BToday";
            this.BToday.Size = new System.Drawing.Size(91, 53);
            this.BToday.TabIndex = 21;
            this.BToday.Text = "Today";
            this.BToday.UseVisualStyleBackColor = true;
            // 
            // BData
            // 
            this.BData.Location = new System.Drawing.Point(82, 610);
            this.BData.Name = "BData";
            this.BData.Size = new System.Drawing.Size(80, 53);
            this.BData.TabIndex = 20;
            this.BData.Text = "Data";
            this.BData.UseVisualStyleBackColor = true;
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 610);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(85, 53);
            this.BHome.TabIndex = 19;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // BHomeUpperLeft
            // 
            this.BHomeUpperLeft.Location = new System.Drawing.Point(0, 0);
            this.BHomeUpperLeft.Name = "BHomeUpperLeft";
            this.BHomeUpperLeft.Size = new System.Drawing.Size(68, 47);
            this.BHomeUpperLeft.TabIndex = 23;
            this.BHomeUpperLeft.Text = "Home";
            this.BHomeUpperLeft.UseVisualStyleBackColor = true;
            this.BHomeUpperLeft.Click += new System.EventHandler(this.BHomeUpperLeft_Click);
            // 
            // LBChallenges
            // 
            this.LBChallenges.FormattingEnabled = true;
            this.LBChallenges.ItemHeight = 16;
            this.LBChallenges.Location = new System.Drawing.Point(1, 80);
            this.LBChallenges.Name = "LBChallenges";
            this.LBChallenges.Size = new System.Drawing.Size(339, 196);
            this.LBChallenges.TabIndex = 24;
            this.LBChallenges.SelectedIndexChanged += new System.EventHandler(this.LBChallenges_SelectedIndexChanged);
            // 
            // FChallenges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.LBChallenges);
            this.Controls.Add(this.BHomeUpperLeft);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.BToday);
            this.Controls.Add(this.BData);
            this.Controls.Add(this.BHome);
            this.Name = "FChallenges";
            this.Text = "Challenges";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button BToday;
        private System.Windows.Forms.Button BData;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.Button BHomeUpperLeft;
        private System.Windows.Forms.ListBox LBChallenges;
    }
}