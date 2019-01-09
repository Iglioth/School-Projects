namespace Killer_App
{
    partial class FormLogIn2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LogInPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BAccountCreatie = new System.Windows.Forms.Button();
            this.BInloggen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogInPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // LogInPictureBox
            // 
            this.LogInPictureBox.Image = global::Killer_App.Properties.Resources.crearlogogratis_1024x1024_01_1_;
            this.LogInPictureBox.ImageLocation = "";
            this.LogInPictureBox.Location = new System.Drawing.Point(41, 27);
            this.LogInPictureBox.Name = "LogInPictureBox";
            this.LogInPictureBox.Size = new System.Drawing.Size(272, 124);
            this.LogInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogInPictureBox.TabIndex = 2;
            this.LogInPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // BAccountCreatie
            // 
            this.BAccountCreatie.Location = new System.Drawing.Point(68, 438);
            this.BAccountCreatie.Name = "BAccountCreatie";
            this.BAccountCreatie.Size = new System.Drawing.Size(182, 65);
            this.BAccountCreatie.TabIndex = 5;
            this.BAccountCreatie.Text = "Geen account? Klik hier voor registratie!";
            this.BAccountCreatie.UseVisualStyleBackColor = true;
            this.BAccountCreatie.Click += new System.EventHandler(this.BAccountCreatie_Click);
            // 
            // BInloggen
            // 
            this.BInloggen.Location = new System.Drawing.Point(159, 341);
            this.BInloggen.Name = "BInloggen";
            this.BInloggen.Size = new System.Drawing.Size(75, 32);
            this.BInloggen.TabIndex = 6;
            this.BInloggen.Text = "Inloggen";
            this.BInloggen.UseVisualStyleBackColor = true;
            this.BInloggen.Click += new System.EventHandler(this.Inloggen_Click);
            // 
            // FormLogIn2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 663);
            this.Controls.Add(this.BInloggen);
            this.Controls.Add(this.BAccountCreatie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInPictureBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormLogIn2";
            this.Text = "Log In:";
            ((System.ComponentModel.ISupportInitialize)(this.LogInPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox LogInPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BAccountCreatie;
        private System.Windows.Forms.Button BInloggen;
    }
}

