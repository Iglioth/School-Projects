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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BProfile = new System.Windows.Forms.Button();
            this.BToday = new System.Windows.Forms.Button();
            this.BData = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 51);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(338, 308);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(61, 371);
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
            this.BToday.Location = new System.Drawing.Point(158, 608);
            this.BToday.Name = "BToday";
            this.BToday.Size = new System.Drawing.Size(91, 53);
            this.BToday.TabIndex = 13;
            this.BToday.Text = "Today";
            this.BToday.UseVisualStyleBackColor = true;
            // 
            // BData
            // 
            this.BData.Location = new System.Drawing.Point(82, 608);
            this.BData.Name = "BData";
            this.BData.Size = new System.Drawing.Size(80, 53);
            this.BData.TabIndex = 12;
            this.BData.Text = "Data";
            this.BData.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.BData);
            this.Controls.Add(this.BHome);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.chart1);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button BToday;
        private System.Windows.Forms.Button BData;
        private System.Windows.Forms.Button BHome;
    }
}