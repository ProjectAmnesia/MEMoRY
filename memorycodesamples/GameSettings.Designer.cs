namespace MemoryCodeSamples
{
    partial class GameSettings
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
            this.grBNumberOfCards = new System.Windows.Forms.GroupBox();
            this.rbUsersChoice = new System.Windows.Forms.RadioButton();
            this.rb36cards = new System.Windows.Forms.RadioButton();
            this.rb24cards = new System.Windows.Forms.RadioButton();
            this.rb16cards = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbNumberOfCards = new System.Windows.Forms.TextBox();
            this.lblCards = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.väljTidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sekToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sekToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.grBTheme = new System.Windows.Forms.GroupBox();
            this.rbtnAnimals = new System.Windows.Forms.RadioButton();
            this.rbtnFruit = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grBNumberOfCards.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grBTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grBNumberOfCards
            // 
            this.grBNumberOfCards.BackColor = System.Drawing.Color.White;
            this.grBNumberOfCards.Controls.Add(this.rbUsersChoice);
            this.grBNumberOfCards.Controls.Add(this.rb36cards);
            this.grBNumberOfCards.Controls.Add(this.rb24cards);
            this.grBNumberOfCards.Controls.Add(this.rb16cards);
            this.grBNumberOfCards.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBNumberOfCards.ForeColor = System.Drawing.Color.MediumBlue;
            this.grBNumberOfCards.Location = new System.Drawing.Point(165, 89);
            this.grBNumberOfCards.Margin = new System.Windows.Forms.Padding(4);
            this.grBNumberOfCards.Name = "grBNumberOfCards";
            this.grBNumberOfCards.Padding = new System.Windows.Forms.Padding(4);
            this.grBNumberOfCards.Size = new System.Drawing.Size(165, 117);
            this.grBNumberOfCards.TabIndex = 0;
            this.grBNumberOfCards.TabStop = false;
            this.grBNumberOfCards.Text = "Antal kort";
            this.grBNumberOfCards.Visible = false;
            // 
            // rbUsersChoice
            // 
            this.rbUsersChoice.AutoSize = true;
            this.rbUsersChoice.Location = new System.Drawing.Point(9, 88);
            this.rbUsersChoice.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsersChoice.Name = "rbUsersChoice";
            this.rbUsersChoice.Size = new System.Drawing.Size(135, 24);
            this.rbUsersChoice.TabIndex = 0;
            this.rbUsersChoice.Text = "Fritt antal kort";
            this.rbUsersChoice.UseVisualStyleBackColor = true;
            this.rbUsersChoice.CheckedChanged += new System.EventHandler(this.rbUsersChoice_CheckedChanged);
            // 
            // rb36cards
            // 
            this.rb36cards.AutoSize = true;
            this.rb36cards.Location = new System.Drawing.Point(9, 66);
            this.rb36cards.Margin = new System.Windows.Forms.Padding(4);
            this.rb36cards.Name = "rb36cards";
            this.rb36cards.Size = new System.Drawing.Size(80, 24);
            this.rb36cards.TabIndex = 0;
            this.rb36cards.Text = "36 kort";
            this.rb36cards.UseVisualStyleBackColor = true;
            // 
            // rb24cards
            // 
            this.rb24cards.AutoSize = true;
            this.rb24cards.Location = new System.Drawing.Point(9, 44);
            this.rb24cards.Margin = new System.Windows.Forms.Padding(4);
            this.rb24cards.Name = "rb24cards";
            this.rb24cards.Size = new System.Drawing.Size(80, 24);
            this.rb24cards.TabIndex = 0;
            this.rb24cards.Text = "24 kort";
            this.rb24cards.UseVisualStyleBackColor = true;
            // 
            // rb16cards
            // 
            this.rb16cards.AutoSize = true;
            this.rb16cards.Checked = true;
            this.rb16cards.Location = new System.Drawing.Point(9, 18);
            this.rb16cards.Margin = new System.Windows.Forms.Padding(4);
            this.rb16cards.Name = "rb16cards";
            this.rb16cards.Size = new System.Drawing.Size(78, 24);
            this.rb16cards.TabIndex = 0;
            this.rb16cards.TabStop = true;
            this.rb16cards.Text = "16 kort";
            this.rb16cards.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightBlue;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPlay.Location = new System.Drawing.Point(192, 354);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(137, 35);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Börja spela!";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // tbNumberOfCards
            // 
            this.tbNumberOfCards.BackColor = System.Drawing.Color.LightBlue;
            this.tbNumberOfCards.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberOfCards.ForeColor = System.Drawing.Color.MediumBlue;
            this.tbNumberOfCards.Location = new System.Drawing.Point(192, 230);
            this.tbNumberOfCards.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumberOfCards.Name = "tbNumberOfCards";
            this.tbNumberOfCards.Size = new System.Drawing.Size(116, 28);
            this.tbNumberOfCards.TabIndex = 2;
            this.tbNumberOfCards.Visible = false;
            // 
            // lblCards
            // 
            this.lblCards.AutoSize = true;
            this.lblCards.BackColor = System.Drawing.Color.White;
            this.lblCards.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCards.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblCards.Location = new System.Drawing.Point(206, 210);
            this.lblCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(86, 20);
            this.lblCards.TabIndex = 3;
            this.lblCards.Text = "Antal kort:";
            this.lblCards.Visible = false;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.White;
            this.lblMax.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblMax.Location = new System.Drawing.Point(201, 261);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(96, 20);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "(max 120 st)";
            this.lblMax.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnCancel.Location = new System.Drawing.Point(381, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Avsluta";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(13, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 45);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljTidToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(143, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // väljTidToolStripMenuItem
            // 
            this.väljTidToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.väljTidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sekToolStripMenuItem,
            this.sekToolStripMenuItem1,
            this.sekToolStripMenuItem2,
            this.sekToolStripMenuItem3});
            this.väljTidToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue;
            this.väljTidToolStripMenuItem.Name = "väljTidToolStripMenuItem";
            this.väljTidToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.väljTidToolStripMenuItem.Text = "Välj betänketid";
            // 
            // sekToolStripMenuItem
            // 
            this.sekToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.sekToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue;
            this.sekToolStripMenuItem.Name = "sekToolStripMenuItem";
            this.sekToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.sekToolStripMenuItem.Text = "2 sek";
            // 
            // sekToolStripMenuItem1
            // 
            this.sekToolStripMenuItem1.BackColor = System.Drawing.Color.LightBlue;
            this.sekToolStripMenuItem1.ForeColor = System.Drawing.Color.MediumBlue;
            this.sekToolStripMenuItem1.Name = "sekToolStripMenuItem1";
            this.sekToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.sekToolStripMenuItem1.Text = "3 sek";
            
            // 
            // sekToolStripMenuItem2
            // 
            this.sekToolStripMenuItem2.BackColor = System.Drawing.Color.LightBlue;
            this.sekToolStripMenuItem2.ForeColor = System.Drawing.Color.MediumBlue;
            this.sekToolStripMenuItem2.Name = "sekToolStripMenuItem2";
            this.sekToolStripMenuItem2.Size = new System.Drawing.Size(152, 24);
            this.sekToolStripMenuItem2.Text = "4 sek";
            // 
            // sekToolStripMenuItem3
            // 
            this.sekToolStripMenuItem3.BackColor = System.Drawing.Color.LightBlue;
            this.sekToolStripMenuItem3.ForeColor = System.Drawing.Color.MediumBlue;
            this.sekToolStripMenuItem3.Name = "sekToolStripMenuItem3";
            this.sekToolStripMenuItem3.Size = new System.Drawing.Size(152, 24);
            this.sekToolStripMenuItem3.Text = "5 sek";
            // 
            // grBTheme
            // 
            this.grBTheme.BackColor = System.Drawing.Color.White;
            this.grBTheme.Controls.Add(this.rbtnAnimals);
            this.grBTheme.Controls.Add(this.rbtnFruit);
            this.grBTheme.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBTheme.ForeColor = System.Drawing.Color.MediumBlue;
            this.grBTheme.Location = new System.Drawing.Point(162, 107);
            this.grBTheme.Name = "grBTheme";
            this.grBTheme.Size = new System.Drawing.Size(168, 131);
            this.grBTheme.TabIndex = 6;
            this.grBTheme.TabStop = false;
            this.grBTheme.Text = "Tema på korten";
            this.grBTheme.Visible = false;
            // 
            // rbtnAnimals
            // 
            this.rbtnAnimals.AutoSize = true;
            this.rbtnAnimals.Location = new System.Drawing.Point(9, 57);
            this.rbtnAnimals.Name = "rbtnAnimals";
            this.rbtnAnimals.Size = new System.Drawing.Size(59, 24);
            this.rbtnAnimals.TabIndex = 7;
            this.rbtnAnimals.TabStop = true;
            this.rbtnAnimals.Text = "Djur";
            this.rbtnAnimals.UseVisualStyleBackColor = true;
            this.rbtnAnimals.CheckedChanged += new System.EventHandler(this.rbtnAnimals_CheckedChanged);
            // 
            // rbtnFruit
            // 
            this.rbtnFruit.AutoSize = true;
            this.rbtnFruit.Location = new System.Drawing.Point(9, 27);
            this.rbtnFruit.Name = "rbtnFruit";
            this.rbtnFruit.Size = new System.Drawing.Size(137, 24);
            this.rbtnFruit.TabIndex = 7;
            this.rbtnFruit.TabStop = true;
            this.rbtnFruit.Text = "Frukt och grönt";
            this.rbtnFruit.UseVisualStyleBackColor = true;
            this.rbtnFruit.CheckedChanged += new System.EventHandler(this.rbtnFruit_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::MemoryCodeSamples.Properties.Resources.cloudBG;
            this.pictureBox1.Location = new System.Drawing.Point(117, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryCodeSamples.Properties.Resources.rainbowSplashScreenBG1;
            this.ClientSize = new System.Drawing.Size(484, 393);
            this.Controls.Add(this.grBNumberOfCards);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblCards);
            this.Controls.Add(this.tbNumberOfCards);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grBTheme);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inställningar";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            this.grBNumberOfCards.ResumeLayout(false);
            this.grBNumberOfCards.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBTheme.ResumeLayout(false);
            this.grBTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBNumberOfCards;
        private System.Windows.Forms.RadioButton rb36cards;
        private System.Windows.Forms.RadioButton rb24cards;
        private System.Windows.Forms.RadioButton rb16cards;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbUsersChoice;
        private System.Windows.Forms.TextBox tbNumberOfCards;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem väljTidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sekToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sekToolStripMenuItem3;
        private System.Windows.Forms.GroupBox grBTheme;
        private System.Windows.Forms.RadioButton rbtnAnimals;
        private System.Windows.Forms.RadioButton rbtnFruit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}