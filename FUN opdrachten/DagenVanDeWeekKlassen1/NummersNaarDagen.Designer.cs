namespace DagenVanDeWeekKlassen1
{
    partial class NummersNaarDagen
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
            this.VanIntNaarStringButton = new System.Windows.Forms.Button();
            this.VanInstNaarStringTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VanIntNaarStringButton
            // 
            this.VanIntNaarStringButton.Location = new System.Drawing.Point(12, 99);
            this.VanIntNaarStringButton.Name = "VanIntNaarStringButton";
            this.VanIntNaarStringButton.Size = new System.Drawing.Size(91, 23);
            this.VanIntNaarStringButton.TabIndex = 0;
            this.VanIntNaarStringButton.Text = "Transform!";
            this.VanIntNaarStringButton.UseVisualStyleBackColor = true;
            this.VanIntNaarStringButton.Click += new System.EventHandler(this.VanIntNaarStringButton_Click);
            // 
            // VanInstNaarStringTextBox
            // 
            this.VanInstNaarStringTextBox.Location = new System.Drawing.Point(137, 99);
            this.VanInstNaarStringTextBox.Name = "VanInstNaarStringTextBox";
            this.VanInstNaarStringTextBox.Size = new System.Drawing.Size(100, 22);
            this.VanInstNaarStringTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.VanInstNaarStringTextBox);
            this.Controls.Add(this.VanIntNaarStringButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VanIntNaarStringButton;
        private System.Windows.Forms.TextBox VanInstNaarStringTextBox;
    }
}

