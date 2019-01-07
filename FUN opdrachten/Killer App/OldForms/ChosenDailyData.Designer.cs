namespace Killer_App
{
    partial class ChosenDailyData
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BProfile = new System.Windows.Forms.Button();
            this.BToday = new System.Windows.Forms.Button();
            this.BData = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.BScoreTrack = new System.Windows.Forms.Button();
            this.BChooseDate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BHomeUpperLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(245, 611);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(97, 53);
            this.BProfile.TabIndex = 22;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            // 
            // BToday
            // 
            this.BToday.Location = new System.Drawing.Point(158, 611);
            this.BToday.Name = "BToday";
            this.BToday.Size = new System.Drawing.Size(91, 53);
            this.BToday.TabIndex = 21;
            this.BToday.Text = "Today";
            this.BToday.UseVisualStyleBackColor = true;
            // 
            // BData
            // 
            this.BData.Location = new System.Drawing.Point(82, 611);
            this.BData.Name = "BData";
            this.BData.Size = new System.Drawing.Size(80, 53);
            this.BData.TabIndex = 20;
            this.BData.Text = "Data";
            this.BData.UseVisualStyleBackColor = true;
            // 
            // BHome
            // 
            this.BHome.Location = new System.Drawing.Point(0, 611);
            this.BHome.Name = "BHome";
            this.BHome.Size = new System.Drawing.Size(85, 53);
            this.BHome.TabIndex = 19;
            this.BHome.Text = "Home";
            this.BHome.UseVisualStyleBackColor = true;
            // 
            // BScoreTrack
            // 
            this.BScoreTrack.Location = new System.Drawing.Point(158, 545);
            this.BScoreTrack.Name = "BScoreTrack";
            this.BScoreTrack.Size = new System.Drawing.Size(184, 23);
            this.BScoreTrack.TabIndex = 18;
            this.BScoreTrack.Text = "Score Track";
            this.BScoreTrack.UseVisualStyleBackColor = true;
            // 
            // BChooseDate
            // 
            this.BChooseDate.Location = new System.Drawing.Point(0, 545);
            this.BChooseDate.Name = "BChooseDate";
            this.BChooseDate.Size = new System.Drawing.Size(162, 23);
            this.BChooseDate.TabIndex = 17;
            this.BChooseDate.Text = "Choose Date";
            this.BChooseDate.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 306);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(342, 233);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // BHomeUpperLeft
            // 
            this.BHomeUpperLeft.Location = new System.Drawing.Point(0, 0);
            this.BHomeUpperLeft.Name = "BHomeUpperLeft";
            this.BHomeUpperLeft.Size = new System.Drawing.Size(74, 49);
            this.BHomeUpperLeft.TabIndex = 24;
            this.BHomeUpperLeft.Text = "Home";
            this.BHomeUpperLeft.UseVisualStyleBackColor = true;
            // 
            // ChosenDailyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.BHomeUpperLeft);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.BToday);
            this.Controls.Add(this.BData);
            this.Controls.Add(this.BHome);
            this.Controls.Add(this.BScoreTrack);
            this.Controls.Add(this.BChooseDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ChosenDailyData";
            this.Text = "ChosenDailyData";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button BToday;
        private System.Windows.Forms.Button BData;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.Button BScoreTrack;
        private System.Windows.Forms.Button BChooseDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BHomeUpperLeft;
    }
}