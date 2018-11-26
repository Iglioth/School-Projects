namespace BandAKlassen1
{
    partial class Form1
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
            this.GBBands = new System.Windows.Forms.GroupBox();
            this.RBCompare = new System.Windows.Forms.RadioButton();
            this.RBImagineDragons = new System.Windows.Forms.RadioButton();
            this.RBSlipknot = new System.Windows.Forms.RadioButton();
            this.RBHeadAndTheHeart = new System.Windows.Forms.RadioButton();
            this.RBPassenger = new System.Windows.Forms.RadioButton();
            this.GBInfo = new System.Windows.Forms.GroupBox();
            this.LBBands = new System.Windows.Forms.ListBox();
            this.LPlayers = new System.Windows.Forms.Label();
            this.LHourPay = new System.Windows.Forms.Label();
            this.LGenre = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.GBBooking = new System.Windows.Forms.GroupBox();
            this.BCalculate = new System.Windows.Forms.Button();
            this.LSong = new System.Windows.Forms.TextBox();
            this.LCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUPBand = new System.Windows.Forms.NumericUpDown();
            this.GBBands.SuspendLayout();
            this.GBInfo.SuspendLayout();
            this.GBBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPBand)).BeginInit();
            this.SuspendLayout();
            // 
            // GBBands
            // 
            this.GBBands.Controls.Add(this.RBCompare);
            this.GBBands.Controls.Add(this.RBImagineDragons);
            this.GBBands.Controls.Add(this.RBSlipknot);
            this.GBBands.Controls.Add(this.RBHeadAndTheHeart);
            this.GBBands.Controls.Add(this.RBPassenger);
            this.GBBands.Location = new System.Drawing.Point(0, 0);
            this.GBBands.Name = "GBBands";
            this.GBBands.Size = new System.Drawing.Size(178, 199);
            this.GBBands.TabIndex = 0;
            this.GBBands.TabStop = false;
            this.GBBands.Text = "Choose Band";
            // 
            // RBCompare
            // 
            this.RBCompare.AutoSize = true;
            this.RBCompare.Location = new System.Drawing.Point(12, 172);
            this.RBCompare.Name = "RBCompare";
            this.RBCompare.Size = new System.Drawing.Size(86, 21);
            this.RBCompare.TabIndex = 4;
            this.RBCompare.TabStop = true;
            this.RBCompare.Text = "Compare";
            this.RBCompare.UseVisualStyleBackColor = true;
            this.RBCompare.CheckedChanged += new System.EventHandler(this.RBCompare_CheckedChanged);
            // 
            // RBImagineDragons
            // 
            this.RBImagineDragons.AutoSize = true;
            this.RBImagineDragons.Location = new System.Drawing.Point(12, 26);
            this.RBImagineDragons.Name = "RBImagineDragons";
            this.RBImagineDragons.Size = new System.Drawing.Size(136, 21);
            this.RBImagineDragons.TabIndex = 3;
            this.RBImagineDragons.TabStop = true;
            this.RBImagineDragons.Text = "Imagine Dragons";
            this.RBImagineDragons.UseVisualStyleBackColor = true;
            this.RBImagineDragons.CheckedChanged += new System.EventHandler(this.RBImagineDragons_CheckedChanged);
            // 
            // RBSlipknot
            // 
            this.RBSlipknot.AutoSize = true;
            this.RBSlipknot.Location = new System.Drawing.Point(12, 133);
            this.RBSlipknot.Name = "RBSlipknot";
            this.RBSlipknot.Size = new System.Drawing.Size(79, 21);
            this.RBSlipknot.TabIndex = 2;
            this.RBSlipknot.TabStop = true;
            this.RBSlipknot.Text = "Slipknot";
            this.RBSlipknot.UseVisualStyleBackColor = true;
            this.RBSlipknot.CheckedChanged += new System.EventHandler(this.RBSlipknot_CheckedChanged);
            // 
            // RBHeadAndTheHeart
            // 
            this.RBHeadAndTheHeart.AutoSize = true;
            this.RBHeadAndTheHeart.Location = new System.Drawing.Point(12, 97);
            this.RBHeadAndTheHeart.Name = "RBHeadAndTheHeart";
            this.RBHeadAndTheHeart.Size = new System.Drawing.Size(154, 21);
            this.RBHeadAndTheHeart.TabIndex = 1;
            this.RBHeadAndTheHeart.TabStop = true;
            this.RBHeadAndTheHeart.Text = "Head and the Heart";
            this.RBHeadAndTheHeart.UseVisualStyleBackColor = true;
            this.RBHeadAndTheHeart.CheckedChanged += new System.EventHandler(this.RBHeadAndTheHeart_CheckedChanged);
            // 
            // RBPassenger
            // 
            this.RBPassenger.AutoSize = true;
            this.RBPassenger.Location = new System.Drawing.Point(12, 61);
            this.RBPassenger.Name = "RBPassenger";
            this.RBPassenger.Size = new System.Drawing.Size(97, 21);
            this.RBPassenger.TabIndex = 0;
            this.RBPassenger.TabStop = true;
            this.RBPassenger.Text = "Passenger";
            this.RBPassenger.UseVisualStyleBackColor = true;
            this.RBPassenger.CheckedChanged += new System.EventHandler(this.RBPassenger_CheckedChanged);
            // 
            // GBInfo
            // 
            this.GBInfo.Controls.Add(this.LBBands);
            this.GBInfo.Controls.Add(this.LPlayers);
            this.GBInfo.Controls.Add(this.LHourPay);
            this.GBInfo.Controls.Add(this.LGenre);
            this.GBInfo.Controls.Add(this.LName);
            this.GBInfo.Location = new System.Drawing.Point(189, 0);
            this.GBInfo.Name = "GBInfo";
            this.GBInfo.Size = new System.Drawing.Size(221, 199);
            this.GBInfo.TabIndex = 1;
            this.GBInfo.TabStop = false;
            this.GBInfo.Text = "Info";
            // 
            // LBBands
            // 
            this.LBBands.FormattingEnabled = true;
            this.LBBands.ItemHeight = 16;
            this.LBBands.Location = new System.Drawing.Point(6, 1);
            this.LBBands.Name = "LBBands";
            this.LBBands.Size = new System.Drawing.Size(209, 196);
            this.LBBands.TabIndex = 3;
            this.LBBands.Visible = false;
            // 
            // LPlayers
            // 
            this.LPlayers.AutoSize = true;
            this.LPlayers.Location = new System.Drawing.Point(23, 156);
            this.LPlayers.Name = "LPlayers";
            this.LPlayers.Size = new System.Drawing.Size(74, 17);
            this.LPlayers.TabIndex = 3;
            this.LPlayers.Text = "Musicians:";
            // 
            // LHourPay
            // 
            this.LHourPay.AutoSize = true;
            this.LHourPay.Location = new System.Drawing.Point(23, 123);
            this.LHourPay.Name = "LHourPay";
            this.LHourPay.Size = new System.Drawing.Size(98, 17);
            this.LHourPay.TabIndex = 2;
            this.LHourPay.Text = "Cost per hour:";
            // 
            // LGenre
            // 
            this.LGenre.AutoSize = true;
            this.LGenre.Location = new System.Drawing.Point(23, 88);
            this.LGenre.Name = "LGenre";
            this.LGenre.Size = new System.Drawing.Size(52, 17);
            this.LGenre.TabIndex = 1;
            this.LGenre.Text = "Genre:";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(23, 50);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(49, 17);
            this.LName.TabIndex = 0;
            this.LName.Text = "Name:";
            // 
            // GBBooking
            // 
            this.GBBooking.Controls.Add(this.BCalculate);
            this.GBBooking.Controls.Add(this.LSong);
            this.GBBooking.Controls.Add(this.LCost);
            this.GBBooking.Controls.Add(this.label6);
            this.GBBooking.Controls.Add(this.label5);
            this.GBBooking.Controls.Add(this.NUPBand);
            this.GBBooking.Location = new System.Drawing.Point(416, 0);
            this.GBBooking.Name = "GBBooking";
            this.GBBooking.Size = new System.Drawing.Size(246, 199);
            this.GBBooking.TabIndex = 2;
            this.GBBooking.TabStop = false;
            this.GBBooking.Text = "Booking";
            // 
            // BCalculate
            // 
            this.BCalculate.Location = new System.Drawing.Point(76, 129);
            this.BCalculate.Name = "BCalculate";
            this.BCalculate.Size = new System.Drawing.Size(75, 23);
            this.BCalculate.TabIndex = 5;
            this.BCalculate.Text = "Calculate";
            this.BCalculate.UseVisualStyleBackColor = true;
            this.BCalculate.Click += new System.EventHandler(this.BCalculate_Click);
            // 
            // LSong
            // 
            this.LSong.Location = new System.Drawing.Point(141, 85);
            this.LSong.Name = "LSong";
            this.LSong.Size = new System.Drawing.Size(83, 22);
            this.LSong.TabIndex = 4;
            // 
            // LCost
            // 
            this.LCost.AutoSize = true;
            this.LCost.Location = new System.Drawing.Point(92, 163);
            this.LCost.Name = "LCost";
            this.LCost.Size = new System.Drawing.Size(40, 17);
            this.LCost.TabIndex = 3;
            this.LCost.Text = "Cost:";
            this.LCost.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Possible new song:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Length of gig (in min):";
            // 
            // NUPBand
            // 
            this.NUPBand.Location = new System.Drawing.Point(158, 45);
            this.NUPBand.Name = "NUPBand";
            this.NUPBand.Size = new System.Drawing.Size(66, 22);
            this.NUPBand.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 214);
            this.Controls.Add(this.GBBooking);
            this.Controls.Add(this.GBInfo);
            this.Controls.Add(this.GBBands);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBBands.ResumeLayout(false);
            this.GBBands.PerformLayout();
            this.GBInfo.ResumeLayout(false);
            this.GBInfo.PerformLayout();
            this.GBBooking.ResumeLayout(false);
            this.GBBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPBand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBBands;
        private System.Windows.Forms.RadioButton RBCompare;
        private System.Windows.Forms.RadioButton RBImagineDragons;
        private System.Windows.Forms.RadioButton RBSlipknot;
        private System.Windows.Forms.RadioButton RBHeadAndTheHeart;
        private System.Windows.Forms.RadioButton RBPassenger;
        private System.Windows.Forms.GroupBox GBInfo;
        private System.Windows.Forms.Label LPlayers;
        private System.Windows.Forms.Label LHourPay;
        private System.Windows.Forms.Label LGenre;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.GroupBox GBBooking;
        private System.Windows.Forms.Button BCalculate;
        private System.Windows.Forms.TextBox LSong;
        private System.Windows.Forms.Label LCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUPBand;
        private System.Windows.Forms.ListBox LBBands;
    }
}

