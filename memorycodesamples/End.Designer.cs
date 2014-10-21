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
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.LightGreen;
            this.btnEndGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndGame.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.ForeColor = System.Drawing.Color.Black;
            this.btnEndGame.Location = new System.Drawing.Point(334, 290);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(74, 34);
            this.btnEndGame.TabIndex = 1;
            this.btnEndGame.Text = "Avsluta";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.LightGreen;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(164, 290);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(79, 34);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Nytt spel";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.White;
            this.lblWinner.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblWinner.Location = new System.Drawing.Point(129, 155);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(216, 29);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "...";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinner.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MemoryCodeSamples.Properties.Resources.endScreen;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LightGreen;
            this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(248, 290);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(83, 34);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Omstart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryCodeSamples.Properties.Resources.rainbowSplashScreenBG1;
            this.ClientSize = new System.Drawing.Size(468, 354);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestart;
    }
}