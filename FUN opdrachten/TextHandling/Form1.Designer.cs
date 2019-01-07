namespace TextHandling
{
    partial class FileHandlingForm
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
            this.LBC = new System.Windows.Forms.ListBox();
            this.LBCFurther = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBC
            // 
            this.LBC.FormattingEnabled = true;
            this.LBC.ItemHeight = 16;
            this.LBC.Location = new System.Drawing.Point(43, 35);
            this.LBC.Name = "LBC";
            this.LBC.Size = new System.Drawing.Size(120, 276);
            this.LBC.TabIndex = 0;
            this.LBC.SelectedIndexChanged += new System.EventHandler(this.LBC_SelectedIndexChanged);
            // 
            // LBCFurther
            // 
            this.LBCFurther.FormattingEnabled = true;
            this.LBCFurther.ItemHeight = 16;
            this.LBCFurther.Location = new System.Drawing.Point(257, 35);
            this.LBCFurther.Name = "LBCFurther";
            this.LBCFurther.Size = new System.Drawing.Size(120, 276);
            this.LBCFurther.TabIndex = 1;
            // 
            // FileHandlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 350);
            this.Controls.Add(this.LBCFurther);
            this.Controls.Add(this.LBC);
            this.Name = "FileHandlingForm";
            this.Text = "Verkenner";
            this.Load += new System.EventHandler(this.FileHandlingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBC;
        private System.Windows.Forms.ListBox LBCFurther;
    }
}

