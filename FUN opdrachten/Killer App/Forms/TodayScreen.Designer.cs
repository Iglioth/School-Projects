namespace Killer_App
{
    partial class TodayScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CToday = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BProfile = new System.Windows.Forms.Button();
            this.BToday = new System.Windows.Forms.Button();
            this.BData = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.BHomeUpperLeft = new System.Windows.Forms.Button();
            this.BFinish = new System.Windows.Forms.Button();
            this.BTodayData = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BAddChallenge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CToday)).BeginInit();
            this.SuspendLayout();
            // 
            // CToday
            // 
            chartArea1.Name = "ChartArea1";
            this.CToday.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CToday.Legends.Add(legend1);
            this.CToday.Location = new System.Drawing.Point(21, 42);
            this.CToday.Name = "CToday";
            this.CToday.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CToday.Series.Add(series1);
            this.CToday.Size = new System.Drawing.Size(300, 239);
            this.CToday.TabIndex = 1;
            this.CToday.Text = "Today Chart";
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(245, 609);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(97, 53);
            this.BProfile.TabIndex = 14;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            // 
            // BToday
            // 
            this.BToday.Location = new System.Drawing.Point(158, 609);
            this.BToday.Name = "BToday";
            this.BToday.Size = new System.Drawing.Size(91, 53);
            this.BToday.TabIndex = 13;
            this.BToday.Text = "Today";
            this.BToday.UseVisualStyleBackColor = true;
            // 
            // BData
            // 
            this.BData.Location = new System.Drawing.Point(82, 609);
            this.BData.Name = "BData";
            this.BData.Size = new System.Drawing.Size(80, 53);
            this.BData.TabIndex = 12;
            this.BData.Text = "Data";
            this.BData.UseVisualStyleBackColor = true;
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 609);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(85, 53);
            this.BHome.TabIndex = 11;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // BHomeUpperLeft
            // 
            this.BHomeUpperLeft.Location = new System.Drawing.Point(0, 1);
            this.BHomeUpperLeft.Name = "BHomeUpperLeft";
            this.BHomeUpperLeft.Size = new System.Drawing.Size(71, 53);
            this.BHomeUpperLeft.TabIndex = 15;
            this.BHomeUpperLeft.Text = "Home";
            this.BHomeUpperLeft.UseVisualStyleBackColor = true;
            // 
            // BFinish
            // 
            this.BFinish.Location = new System.Drawing.Point(200, 306);
            this.BFinish.Name = "BFinish";
            this.BFinish.Size = new System.Drawing.Size(109, 66);
            this.BFinish.TabIndex = 16;
            this.BFinish.Text = "Finish";
            this.BFinish.UseVisualStyleBackColor = true;
            // 
            // BTodayData
            // 
            this.BTodayData.Location = new System.Drawing.Point(200, 392);
            this.BTodayData.Name = "BTodayData";
            this.BTodayData.Size = new System.Drawing.Size(109, 65);
            this.BTodayData.TabIndex = 17;
            this.BTodayData.Text = "Today\'s Data";
            this.BTodayData.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(2, 306);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(187, 276);
            this.checkedListBox1.TabIndex = 18;
            // 
            // BAddChallenge
            // 
            this.BAddChallenge.Location = new System.Drawing.Point(200, 473);
            this.BAddChallenge.Name = "BAddChallenge";
            this.BAddChallenge.Size = new System.Drawing.Size(109, 64);
            this.BAddChallenge.TabIndex = 19;
            this.BAddChallenge.Text = "Add new Daily Challenge";
            this.BAddChallenge.UseVisualStyleBackColor = true;
            // 
            // TodayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.BAddChallenge);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.BTodayData);
            this.Controls.Add(this.BFinish);
            this.Controls.Add(this.BHomeUpperLeft);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.BToday);
            this.Controls.Add(this.BData);
            this.Controls.Add(this.BHome);
            this.Controls.Add(this.CToday);
            this.Name = "TodayScreen";
            this.Text = "TodayScreen";
            this.Load += new System.EventHandler(this.TodayScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CToday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CToday;
        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button BToday;
        private System.Windows.Forms.Button BData;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.Button BHomeUpperLeft;
        private System.Windows.Forms.Button BFinish;
        private System.Windows.Forms.Button BTodayData;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button BAddChallenge;
    }
}