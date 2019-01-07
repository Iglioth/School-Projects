namespace Killer_App
{
    partial class Score_Track
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
            this.button1 = new System.Windows.Forms.Button();
            this.BChooseDate = new System.Windows.Forms.Button();
            this.BScoreTrack = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.BData = new System.Windows.Forms.Button();
            this.BToday = new System.Windows.Forms.Button();
            this.BProfile = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Button();
            this.BMonth = new System.Windows.Forms.Button();
            this.BWeek = new System.Windows.Forms.Button();
            this.BDay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 49);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "% Reached";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(318, 307);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BChooseDate
            // 
            this.BChooseDate.Location = new System.Drawing.Point(0, 543);
            this.BChooseDate.Name = "BChooseDate";
            this.BChooseDate.Size = new System.Drawing.Size(162, 23);
            this.BChooseDate.TabIndex = 2;
            this.BChooseDate.Text = "Choose Date";
            this.BChooseDate.UseVisualStyleBackColor = true;
            // 
            // BScoreTrack
            // 
            this.BScoreTrack.Location = new System.Drawing.Point(158, 543);
            this.BScoreTrack.Name = "BScoreTrack";
            this.BScoreTrack.Size = new System.Drawing.Size(184, 23);
            this.BScoreTrack.TabIndex = 6;
            this.BScoreTrack.Text = "Score Track";
            this.BScoreTrack.UseVisualStyleBackColor = true;
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 609);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(85, 53);
            this.BHome.TabIndex = 7;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // BData
            // 
            this.BData.Location = new System.Drawing.Point(82, 609);
            this.BData.Name = "BData";
            this.BData.Size = new System.Drawing.Size(80, 53);
            this.BData.TabIndex = 8;
            this.BData.Text = "Data";
            this.BData.UseVisualStyleBackColor = true;
            // 
            // BToday
            // 
            this.BToday.Location = new System.Drawing.Point(158, 609);
            this.BToday.Name = "BToday";
            this.BToday.Size = new System.Drawing.Size(91, 53);
            this.BToday.TabIndex = 9;
            this.BToday.Text = "Today";
            this.BToday.UseVisualStyleBackColor = true;
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(245, 609);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(97, 53);
            this.BProfile.TabIndex = 10;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(245, 359);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(97, 53);
            this.Year.TabIndex = 14;
            this.Year.Text = "Year";
            this.Year.UseVisualStyleBackColor = true;
            this.Year.Click += new System.EventHandler(this.button2_Click);
            // 
            // BMonth
            // 
            this.BMonth.Location = new System.Drawing.Point(158, 359);
            this.BMonth.Name = "BMonth";
            this.BMonth.Size = new System.Drawing.Size(91, 53);
            this.BMonth.TabIndex = 13;
            this.BMonth.Text = "Month";
            this.BMonth.UseVisualStyleBackColor = true;
            this.BMonth.Click += new System.EventHandler(this.button3_Click);
            // 
            // BWeek
            // 
            this.BWeek.Location = new System.Drawing.Point(82, 359);
            this.BWeek.Name = "BWeek";
            this.BWeek.Size = new System.Drawing.Size(80, 53);
            this.BWeek.TabIndex = 12;
            this.BWeek.Text = "Week";
            this.BWeek.UseVisualStyleBackColor = true;
            this.BWeek.Click += new System.EventHandler(this.button4_Click);
            // 
            // BDay
            // 
            this.BDay.Location = new System.Drawing.Point(0, 359);
            this.BDay.Name = "BDay";
            this.BDay.Size = new System.Drawing.Size(85, 53);
            this.BDay.TabIndex = 11;
            this.BDay.Text = "Today";
            this.BDay.UseVisualStyleBackColor = true;
            this.BDay.Click += new System.EventHandler(this.button5_Click);
            // 
            // Score_Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.BMonth);
            this.Controls.Add(this.BWeek);
            this.Controls.Add(this.BDay);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.BToday);
            this.Controls.Add(this.BData);
            this.Controls.Add(this.BHome);
            this.Controls.Add(this.BScoreTrack);
            this.Controls.Add(this.BChooseDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Score_Track";
            this.Text = "Score_Track";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BChooseDate;
        private System.Windows.Forms.Button BScoreTrack;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.Button BData;
        private System.Windows.Forms.Button BToday;
        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button Year;
        private System.Windows.Forms.Button BMonth;
        private System.Windows.Forms.Button BWeek;
        private System.Windows.Forms.Button BDay;
    }
}