namespace MemoryCodeSamples
{
    partial class End
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
            this.lblCongrats = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.BackColor = System.Drawing.Color.Transparent;
            this.lblCongrats.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.ForeColor = System.Drawing.Color.Navy;
            this.lblCongrats.Location = new System.Drawing.Point(206, 76);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(89, 29);
            this.lblCongrats.TabIndex = 0;
            this.lblCongrats.Text = "Grattis!";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNo.Location = new System.Drawing.Point(262, 279);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(104, 34);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Nej";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.LightBlue;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnYes.Location = new System.Drawing.Point(130, 279);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(104, 34);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Ja!";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWinner.Location = new System.Drawing.Point(226, 148);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(25, 29);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "...";
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.AutoSize = true;
            this.lblPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayAgain.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPlayAgain.Location = new System.Drawing.Point(183, 253);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(142, 23);
            this.lblPlayAgain.TabIndex = 0;
            this.lblPlayAgain.Text = "Vill du spela igen?";
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryCodeSamples.Properties.Resources.rainbowSplashScreenBG1;
            this.ClientSize = new System.Drawing.Size(468, 354);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblPlayAgain);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblCongrats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblPlayAgain;
    }
}