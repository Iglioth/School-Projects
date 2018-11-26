namespace RandomGetallenAKlassen1
{
    partial class OddForm
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
            this.OddLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OddLabel
            // 
            this.OddLabel.AutoSize = true;
            this.OddLabel.Location = new System.Drawing.Point(87, 102);
            this.OddLabel.Name = "OddLabel";
            this.OddLabel.Size = new System.Drawing.Size(103, 17);
            this.OddLabel.TabIndex = 0;
            this.OddLabel.Text = "Number is Odd";
            // 
            // OddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.OddLabel);
            this.Name = "OddForm";
            this.Text = "OnevenForm";
            this.Load += new System.EventHandler(this.OddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OddLabel;
    }
}