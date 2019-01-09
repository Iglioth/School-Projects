namespace Killer_App
{
    partial class HomeScreen
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BProfile = new System.Windows.Forms.Button();
            this.BToday = new System.Windows.Forms.Button();
            this.BChallenges = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(64, 113);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(245, 608);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(97, 53);
            this.BProfile.TabIndex = 14;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            // 
            // BToday
            // 
            this.BToday.Location = new System.Drawing.Point(171, 608);
            this.BToday.Name = "BToday";
            this.BToday.Size = new System.Drawing.Size(78, 53);
            this.BToday.TabIndex = 13;
            this.BToday.Text = "Today";
            this.BToday.UseVisualStyleBackColor = true;
            // 
            // BChallenges
            // 
            this.BChallenges.Location = new System.Drawing.Point(82, 608);
            this.BChallenges.Name = "BChallenges";
            this.BChallenges.Size = new System.Drawing.Size(95, 53);
            this.BChallenges.TabIndex = 12;
            this.BChallenges.Text = "Challenges";
            this.BChallenges.UseVisualStyleBackColor = true;
            this.BChallenges.Click += new System.EventHandler(this.BChallenges_Click);
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 608);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(85, 53);
            this.BHome.TabIndex = 11;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.BToday);
            this.Controls.Add(this.BChallenges);
            this.Controls.Add(this.BHome);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button BToday;
        private System.Windows.Forms.Button BChallenges;
        private System.Windows.Forms.Button BHome;
    }
}