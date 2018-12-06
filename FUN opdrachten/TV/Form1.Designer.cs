namespace TV
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
            this.LAddChannel = new System.Windows.Forms.Label();
            this.BForward = new System.Windows.Forms.Button();
            this.BAddChannel = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.BInfo = new System.Windows.Forms.Button();
            this.TBAddChannel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LAddChannel
            // 
            this.LAddChannel.AutoSize = true;
            this.LAddChannel.Location = new System.Drawing.Point(446, 129);
            this.LAddChannel.Name = "LAddChannel";
            this.LAddChannel.Size = new System.Drawing.Size(71, 13);
            this.LAddChannel.TabIndex = 0;
            this.LAddChannel.Text = "Add Channel:";
            // 
            // BForward
            // 
            this.BForward.Location = new System.Drawing.Point(271, 175);
            this.BForward.Name = "BForward";
            this.BForward.Size = new System.Drawing.Size(75, 23);
            this.BForward.TabIndex = 1;
            this.BForward.Text = "--->";
            this.BForward.UseVisualStyleBackColor = true;
            // 
            // BAddChannel
            // 
            this.BAddChannel.Location = new System.Drawing.Point(532, 152);
            this.BAddChannel.Name = "BAddChannel";
            this.BAddChannel.Size = new System.Drawing.Size(75, 23);
            this.BAddChannel.TabIndex = 2;
            this.BAddChannel.Text = "Add";
            this.BAddChannel.UseVisualStyleBackColor = true;
            this.BAddChannel.Click += new System.EventHandler(this.BAddChannel_Click);
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(178, 175);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 23);
            this.BBack.TabIndex = 3;
            this.BBack.Text = "<---";
            this.BBack.UseVisualStyleBackColor = true;
            // 
            // BInfo
            // 
            this.BInfo.Location = new System.Drawing.Point(224, 214);
            this.BInfo.Name = "BInfo";
            this.BInfo.Size = new System.Drawing.Size(75, 23);
            this.BInfo.TabIndex = 4;
            this.BInfo.Text = "Info Channel";
            this.BInfo.UseVisualStyleBackColor = true;
            this.BInfo.Click += new System.EventHandler(this.BInfo_Click);
            // 
            // TBAddChannel
            // 
            this.TBAddChannel.Location = new System.Drawing.Point(523, 126);
            this.TBAddChannel.Name = "TBAddChannel";
            this.TBAddChannel.Size = new System.Drawing.Size(100, 20);
            this.TBAddChannel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBAddChannel);
            this.Controls.Add(this.BInfo);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BAddChannel);
            this.Controls.Add(this.BForward);
            this.Controls.Add(this.LAddChannel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAddChannel;
        private System.Windows.Forms.Button BForward;
        private System.Windows.Forms.Button BAddChannel;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button BInfo;
        private System.Windows.Forms.TextBox TBAddChannel;
    }
}

