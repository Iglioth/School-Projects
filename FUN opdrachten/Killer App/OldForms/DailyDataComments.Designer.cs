namespace Killer_App
{
    partial class DailyDataComments
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
            this.BHomeUpperLeft = new System.Windows.Forms.Button();
            this.BProfile = new System.Windows.Forms.Button();
            this.BToday = new System.Windows.Forms.Button();
            this.BData = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.BScoreTrack = new System.Windows.Forms.Button();
            this.BChooseDate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BHomeUpperLeft
            // 
            this.BHomeUpperLeft.Location = new System.Drawing.Point(0, 0);
            this.BHomeUpperLeft.Name = "BHomeUpperLeft";
            this.BHomeUpperLeft.Size = new System.Drawing.Size(63, 56);
            this.BHomeUpperLeft.TabIndex = 0;
            this.BHomeUpperLeft.Text = "Home";
            this.BHomeUpperLeft.UseVisualStyleBackColor = true;
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(245, 609);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(97, 53);
            this.BProfile.TabIndex = 16;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            // 
            // BToday
            // 
            this.BToday.Location = new System.Drawing.Point(158, 609);
            this.BToday.Name = "BToday";
            this.BToday.Size = new System.Drawing.Size(91, 53);
            this.BToday.TabIndex = 15;
            this.BToday.Text = "Today";
            this.BToday.UseVisualStyleBackColor = true;
            // 
            // BData
            // 
            this.BData.Location = new System.Drawing.Point(82, 609);
            this.BData.Name = "BData";
            this.BData.Size = new System.Drawing.Size(80, 53);
            this.BData.TabIndex = 14;
            this.BData.Text = "Data";
            this.BData.UseVisualStyleBackColor = true;
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 609);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(85, 53);
            this.BHome.TabIndex = 13;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // BScoreTrack
            // 
            this.BScoreTrack.Location = new System.Drawing.Point(158, 543);
            this.BScoreTrack.Name = "BScoreTrack";
            this.BScoreTrack.Size = new System.Drawing.Size(184, 23);
            this.BScoreTrack.TabIndex = 12;
            this.BScoreTrack.Text = "Score Track";
            this.BScoreTrack.UseVisualStyleBackColor = true;
            // 
            // BChooseDate
            // 
            this.BChooseDate.Location = new System.Drawing.Point(0, 543);
            this.BChooseDate.Name = "BChooseDate";
            this.BChooseDate.Size = new System.Drawing.Size(162, 23);
            this.BChooseDate.TabIndex = 11;
            this.BChooseDate.Text = "Choose Date";
            this.BChooseDate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 72);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 283);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 72);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 205);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 72);
            this.textBox3.TabIndex = 19;
            // 
            // DailyDataComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.BToday);
            this.Controls.Add(this.BData);
            this.Controls.Add(this.BHome);
            this.Controls.Add(this.BScoreTrack);
            this.Controls.Add(this.BChooseDate);
            this.Controls.Add(this.BHomeUpperLeft);
            this.Name = "DailyDataComments";
            this.Text = "Comments on Day";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BHomeUpperLeft;
        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button BToday;
        private System.Windows.Forms.Button BData;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.Button BScoreTrack;
        private System.Windows.Forms.Button BChooseDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}