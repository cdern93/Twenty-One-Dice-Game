namespace Twenty_One
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
            this.startBtn = new System.Windows.Forms.Button();
            this.yourNumsLbl = new System.Windows.Forms.Label();
            this.yourNum2Box = new System.Windows.Forms.TextBox();
            this.yourNum1Box = new System.Windows.Forms.TextBox();
            this.currTotLbl = new System.Windows.Forms.Label();
            this.currTotBox = new System.Windows.Forms.TextBox();
            this.rollAgainLbl = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(147, 29);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // yourNumsLbl
            // 
            this.yourNumsLbl.AutoSize = true;
            this.yourNumsLbl.Location = new System.Drawing.Point(129, 82);
            this.yourNumsLbl.Name = "yourNumsLbl";
            this.yourNumsLbl.Size = new System.Drawing.Size(126, 17);
            this.yourNumsLbl.TabIndex = 2;
            this.yourNumsLbl.Text = "Your numbers are:";
            // 
            // yourNum2Box
            // 
            this.yourNum2Box.Location = new System.Drawing.Point(210, 138);
            this.yourNum2Box.Name = "yourNum2Box";
            this.yourNum2Box.Size = new System.Drawing.Size(32, 22);
            this.yourNum2Box.TabIndex = 4;
            // 
            // yourNum1Box
            // 
            this.yourNum1Box.Location = new System.Drawing.Point(147, 138);
            this.yourNum1Box.Name = "yourNum1Box";
            this.yourNum1Box.Size = new System.Drawing.Size(32, 22);
            this.yourNum1Box.TabIndex = 5;
            // 
            // currTotLbl
            // 
            this.currTotLbl.AutoSize = true;
            this.currTotLbl.Location = new System.Drawing.Point(119, 188);
            this.currTotLbl.Name = "currTotLbl";
            this.currTotLbl.Size = new System.Drawing.Size(136, 17);
            this.currTotLbl.TabIndex = 6;
            this.currTotLbl.Text = "Your current total is:";
            // 
            // currTotBox
            // 
            this.currTotBox.Location = new System.Drawing.Point(176, 225);
            this.currTotBox.Name = "currTotBox";
            this.currTotBox.Size = new System.Drawing.Size(32, 22);
            this.currTotBox.TabIndex = 7;
            // 
            // rollAgainLbl
            // 
            this.rollAgainLbl.AutoSize = true;
            this.rollAgainLbl.Location = new System.Drawing.Point(154, 280);
            this.rollAgainLbl.Name = "rollAgainLbl";
            this.rollAgainLbl.Size = new System.Drawing.Size(79, 17);
            this.rollAgainLbl.TabIndex = 9;
            this.rollAgainLbl.Text = "Roll again?";
            // 
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(104, 327);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 23);
            this.yesBtn.TabIndex = 11;
            this.yesBtn.Text = "Yes!";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Location = new System.Drawing.Point(210, 327);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 23);
            this.noBtn.TabIndex = 12;
            this.noBtn.Text = "No...";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(210, 394);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 32);
            this.quitBtn.TabIndex = 13;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.Location = new System.Drawing.Point(85, 394);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(94, 32);
            this.playAgainBtn.TabIndex = 14;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = true;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 454);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.rollAgainLbl);
            this.Controls.Add(this.currTotBox);
            this.Controls.Add(this.currTotLbl);
            this.Controls.Add(this.yourNum1Box);
            this.Controls.Add(this.yourNum2Box);
            this.Controls.Add(this.yourNumsLbl);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Twenty-One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label yourNumsLbl;
        private System.Windows.Forms.TextBox yourNum2Box;
        private System.Windows.Forms.TextBox yourNum1Box;
        private System.Windows.Forms.Label currTotLbl;
        private System.Windows.Forms.TextBox currTotBox;
        private System.Windows.Forms.Label rollAgainLbl;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button playAgainBtn;
    }
}

