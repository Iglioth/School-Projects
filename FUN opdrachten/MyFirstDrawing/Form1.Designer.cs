namespace MyFirstDrawing
{
    partial class DrawingForm
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
            this.BDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BDraw
            // 
            this.BDraw.Location = new System.Drawing.Point(266, 302);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(75, 23);
            this.BDraw.TabIndex = 0;
            this.BDraw.Text = "Draw!";
            this.BDraw.UseVisualStyleBackColor = true;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 357);
            this.Controls.Add(this.BDraw);
            this.Name = "DrawingForm";
            this.Text = "Drawing Form!";
            this.Load += new System.EventHandler(this.DrawingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BDraw;
    }
}

