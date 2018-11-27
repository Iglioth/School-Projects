namespace TVCollecties
{
    partial class FTV
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
            this.TBAdd = new System.Windows.Forms.TextBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BRight = new System.Windows.Forms.Button();
            this.BInfo = new System.Windows.Forms.Button();
            this.BLeft = new System.Windows.Forms.Button();
            this.LAddChannel = new System.Windows.Forms.Label();
            this.BPower = new System.Windows.Forms.Button();
            this.LON = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.LCurrentChannel = new System.Windows.Forms.Label();
            this.LError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBAdd
            // 
            this.TBAdd.Location = new System.Drawing.Point(466, 116);
            this.TBAdd.Name = "TBAdd";
            this.TBAdd.Size = new System.Drawing.Size(197, 22);
            this.TBAdd.TabIndex = 0;
            this.TBAdd.Text = "Insert name here";
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(520, 157);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 1;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BRight
            // 
            this.BRight.Location = new System.Drawing.Point(185, 339);
            this.BRight.Name = "BRight";
            this.BRight.Size = new System.Drawing.Size(75, 23);
            this.BRight.TabIndex = 2;
            this.BRight.Text = "--->";
            this.BRight.UseVisualStyleBackColor = true;
            this.BRight.Click += new System.EventHandler(this.BRight_Click);
            // 
            // BInfo
            // 
            this.BInfo.Location = new System.Drawing.Point(136, 368);
            this.BInfo.Name = "BInfo";
            this.BInfo.Size = new System.Drawing.Size(75, 23);
            this.BInfo.TabIndex = 3;
            this.BInfo.Text = "Info";
            this.BInfo.UseVisualStyleBackColor = true;
            this.BInfo.Click += new System.EventHandler(this.BInfo_Click);
            // 
            // BLeft
            // 
            this.BLeft.Location = new System.Drawing.Point(89, 339);
            this.BLeft.Name = "BLeft";
            this.BLeft.Size = new System.Drawing.Size(75, 23);
            this.BLeft.TabIndex = 4;
            this.BLeft.Text = "<---";
            this.BLeft.UseVisualStyleBackColor = true;
            this.BLeft.Click += new System.EventHandler(this.BLeft_Click);
            // 
            // LAddChannel
            // 
            this.LAddChannel.AutoSize = true;
            this.LAddChannel.Location = new System.Drawing.Point(369, 119);
            this.LAddChannel.Name = "LAddChannel";
            this.LAddChannel.Size = new System.Drawing.Size(91, 17);
            this.LAddChannel.TabIndex = 5;
            this.LAddChannel.Text = "Add channel:";
            // 
            // BPower
            // 
            this.BPower.Location = new System.Drawing.Point(519, 343);
            this.BPower.Name = "BPower";
            this.BPower.Size = new System.Drawing.Size(75, 23);
            this.BPower.TabIndex = 6;
            this.BPower.Text = "Power";
            this.BPower.UseVisualStyleBackColor = true;
            this.BPower.Click += new System.EventHandler(this.BPower_Click);
            // 
            // LON
            // 
            this.LON.AutoSize = true;
            this.LON.Location = new System.Drawing.Point(532, 312);
            this.LON.Name = "LON";
            this.LON.Size = new System.Drawing.Size(32, 17);
            this.LON.TabIndex = 7;
            this.LON.Text = "ON!";
            this.LON.Visible = false;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(297, 371);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(49, 17);
            this.LName.TabIndex = 8;
            this.LName.Text = "Name:";
            // 
            // LCurrentChannel
            // 
            this.LCurrentChannel.AutoSize = true;
            this.LCurrentChannel.Location = new System.Drawing.Point(233, 388);
            this.LCurrentChannel.Name = "LCurrentChannel";
            this.LCurrentChannel.Size = new System.Drawing.Size(113, 17);
            this.LCurrentChannel.TabIndex = 9;
            this.LCurrentChannel.Text = "Current channel:";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.Location = new System.Drawing.Point(152, 296);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(46, 17);
            this.LError.TabIndex = 10;
            this.LError.Text = "label1";
            this.LError.Visible = false;
            // 
            // FTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 427);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.LCurrentChannel);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LON);
            this.Controls.Add(this.BPower);
            this.Controls.Add(this.LAddChannel);
            this.Controls.Add(this.BLeft);
            this.Controls.Add(this.BInfo);
            this.Controls.Add(this.BRight);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TBAdd);
            this.Name = "FTV";
            this.Text = "TV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBAdd;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BRight;
        private System.Windows.Forms.Button BInfo;
        private System.Windows.Forms.Button BLeft;
        private System.Windows.Forms.Label LAddChannel;
        private System.Windows.Forms.Button BPower;
        private System.Windows.Forms.Label LON;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LCurrentChannel;
        private System.Windows.Forms.Label LError;
    }
}

