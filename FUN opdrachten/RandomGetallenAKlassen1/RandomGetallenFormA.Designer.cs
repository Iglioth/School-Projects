namespace RandomGetallenAKlassen1
{
    partial class RandomGetallenFormA
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
            this.RandomButton = new System.Windows.Forms.Button();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.EvenOrOddLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(257, 277);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(102, 33);
            this.RandomButton.TabIndex = 0;
            this.RandomButton.Text = "Randomise!";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(401, 218);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaxTextBox.TabIndex = 1;
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(162, 218);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(100, 22);
            this.MinTextBox.TabIndex = 2;
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(111, 221);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(34, 17);
            this.MinLabel.TabIndex = 3;
            this.MinLabel.Text = "Min:";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(344, 221);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(37, 17);
            this.MaxLabel.TabIndex = 4;
            this.MaxLabel.Text = "Max:";
            // 
            // EvenOrOddLabel
            // 
            this.EvenOrOddLabel.AutoSize = true;
            this.EvenOrOddLabel.Location = new System.Drawing.Point(286, 344);
            this.EvenOrOddLabel.Name = "EvenOrOddLabel";
            this.EvenOrOddLabel.Size = new System.Drawing.Size(76, 17);
            this.EvenOrOddLabel.TabIndex = 5;
            this.EvenOrOddLabel.Text = "Number is ";
            this.EvenOrOddLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "User:";
            // 
            // UserTextbox
            // 
            this.UserTextbox.Location = new System.Drawing.Point(220, 116);
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.Size = new System.Drawing.Size(100, 22);
            this.UserTextbox.TabIndex = 7;
            // 
            // RandomGetallenFormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 558);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EvenOrOddLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.RandomButton);
            this.Name = "RandomGetallenFormA";
            this.Text = "Random Getallen Generator:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label EvenOrOddLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserTextbox;
    }
}

