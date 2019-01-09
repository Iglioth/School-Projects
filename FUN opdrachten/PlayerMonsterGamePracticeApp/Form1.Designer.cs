namespace PlayerMonsterGamePracticeApp
{
    partial class MonsterKillerForm
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
            this.LblMonstersKilled = new System.Windows.Forms.Label();
            this.LMonsterRight = new System.Windows.Forms.Label();
            this.LMonsterLeft = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RBMonsterLeft = new System.Windows.Forms.RadioButton();
            this.RBMonsterRight = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LblMonstersKilled
            // 
            this.LblMonstersKilled.AutoSize = true;
            this.LblMonstersKilled.Location = new System.Drawing.Point(23, 22);
            this.LblMonstersKilled.Name = "LblMonstersKilled";
            this.LblMonstersKilled.Size = new System.Drawing.Size(118, 17);
            this.LblMonstersKilled.TabIndex = 0;
            this.LblMonstersKilled.Text = "Monsters killed: 0";
            // 
            // LMonsterRight
            // 
            this.LMonsterRight.AutoSize = true;
            this.LMonsterRight.Location = new System.Drawing.Point(185, 125);
            this.LMonsterRight.Name = "LMonsterRight";
            this.LMonsterRight.Size = new System.Drawing.Size(81, 17);
            this.LMonsterRight.TabIndex = 1;
            this.LMonsterRight.Text = "Health: 100";
            // 
            // LMonsterLeft
            // 
            this.LMonsterLeft.AutoSize = true;
            this.LMonsterLeft.Location = new System.Drawing.Point(29, 125);
            this.LMonsterLeft.Name = "LMonsterLeft";
            this.LMonsterLeft.Size = new System.Drawing.Size(81, 17);
            this.LMonsterLeft.TabIndex = 2;
            this.LMonsterLeft.Text = "Health: 100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBMonsterLeft
            // 
            this.RBMonsterLeft.AutoSize = true;
            this.RBMonsterLeft.Location = new System.Drawing.Point(26, 101);
            this.RBMonsterLeft.Name = "RBMonsterLeft";
            this.RBMonsterLeft.Size = new System.Drawing.Size(84, 21);
            this.RBMonsterLeft.TabIndex = 7;
            this.RBMonsterLeft.TabStop = true;
            this.RBMonsterLeft.Text = "Monster:";
            this.RBMonsterLeft.UseVisualStyleBackColor = true;
            // 
            // RBMonsterRight
            // 
            this.RBMonsterRight.AutoSize = true;
            this.RBMonsterRight.Location = new System.Drawing.Point(182, 101);
            this.RBMonsterRight.Name = "RBMonsterRight";
            this.RBMonsterRight.Size = new System.Drawing.Size(84, 21);
            this.RBMonsterRight.TabIndex = 8;
            this.RBMonsterRight.TabStop = true;
            this.RBMonsterRight.Text = "Monster:";
            this.RBMonsterRight.UseVisualStyleBackColor = true;
            // 
            // MonsterKillerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.RBMonsterRight);
            this.Controls.Add(this.RBMonsterLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LMonsterLeft);
            this.Controls.Add(this.LMonsterRight);
            this.Controls.Add(this.LblMonstersKilled);
            this.Name = "MonsterKillerForm";
            this.Text = "Monster Killer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMonstersKilled;
        private System.Windows.Forms.Label LMonsterRight;
        private System.Windows.Forms.Label LMonsterLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RBMonsterLeft;
        private System.Windows.Forms.RadioButton RBMonsterRight;
    }
}

