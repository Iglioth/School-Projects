namespace BallBlowerKlassen1
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
            this.BBal = new System.Windows.Forms.Button();
            this.LBal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BBal
            // 
            this.BBal.Location = new System.Drawing.Point(93, 179);
            this.BBal.Name = "BBal";
            this.BBal.Size = new System.Drawing.Size(75, 23);
            this.BBal.TabIndex = 0;
            this.BBal.Text = "Blazen!";
            this.BBal.UseVisualStyleBackColor = true;
            this.BBal.Click += new System.EventHandler(this.BBal_Click);
            // 
            // LBal
            // 
            this.LBal.AutoSize = true;
            this.LBal.Location = new System.Drawing.Point(33, 123);
            this.LBal.Name = "LBal";
            this.LBal.Size = new System.Drawing.Size(249, 17);
            this.LBal.TabIndex = 1;
            this.LBal.Text = "De bal is 0.50 meter groot in diameter!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.LBal);
            this.Controls.Add(this.BBal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBal;
        private System.Windows.Forms.Label LBal;
    }
}

