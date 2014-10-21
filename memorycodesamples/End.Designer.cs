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
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.LightGreen;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.Location = new System.Drawing.Point(334, 290);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(74, 34);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Avsluta";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.LightGreen;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.Black;
            this.btnYes.Location = new System.Drawing.Point(164, 290);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(79, 34);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Nytt spel";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.White;
            this.lblWinner.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblWinner.Location = new System.Drawing.Point(190, 155);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(82, 29);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Omstart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryCodeSamples.Properties.Resources.rainbowSplashScreenBG1;
            this.ClientSize = new System.Drawing.Size(468, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}