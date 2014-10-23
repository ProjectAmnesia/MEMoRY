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
            this.rbUsersChoice = new System.Windows.Forms.RadioButton();
            this.rb36cards = new System.Windows.Forms.RadioButton();
            this.rb24cards = new System.Windows.Forms.RadioButton();
            this.rb16cards = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbNumberOfCards = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbtnCartoon = new System.Windows.Forms.RadioButton();
            this.rbtnAnimals = new System.Windows.Forms.RadioButton();
            this.rbtnFruit = new System.Windows.Forms.RadioButton();
            this.picBoxTheme = new System.Windows.Forms.PictureBox();
            this.picBoxCardAmount = new System.Windows.Forms.PictureBox();
            this.picBoxCardAmountFree = new System.Windows.Forms.PictureBox();
            this.panelTheme = new System.Windows.Forms.Panel();
            this.panel1624 = new System.Windows.Forms.Panel();
            this.panel36free = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCardAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCardAmountFree)).BeginInit();
            this.panelTheme.SuspendLayout();
            this.panel1624.SuspendLayout();
            this.panel36free.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbUsersChoice
            // 
            this.rbUsersChoice.AutoSize = true;
            this.rbUsersChoice.Location = new System.Drawing.Point(6, 26);
            this.rbUsersChoice.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsersChoice.Name = "rbUsersChoice";
            this.rbUsersChoice.Size = new System.Drawing.Size(14, 13);
            this.rbUsersChoice.TabIndex = 0;
            this.rbUsersChoice.UseVisualStyleBackColor = true;
            this.rbUsersChoice.CheckedChanged += new System.EventHandler(this.rbUsersChoice_CheckedChanged);
            // 
            // rb36cards
            // 
            this.rb36cards.AutoSize = true;
            this.rb36cards.Location = new System.Drawing.Point(6, 4);
            this.rb36cards.Margin = new System.Windows.Forms.Padding(4);
            this.rb36cards.Name = "rb36cards";
            this.rb36cards.Size = new System.Drawing.Size(14, 13);
            this.rb36cards.TabIndex = 0;
            this.rb36cards.UseVisualStyleBackColor = true;
            this.rb36cards.CheckedChanged += new System.EventHandler(this.rb36cards_CheckedChanged);
            // 
            // rb24cards
            // 
            this.rb24cards.AutoSize = true;
            this.rb24cards.Location = new System.Drawing.Point(3, 27);
            this.rb24cards.Margin = new System.Windows.Forms.Padding(4);
            this.rb24cards.Name = "rb24cards";
            this.rb24cards.Size = new System.Drawing.Size(14, 13);
            this.rb24cards.TabIndex = 0;
            this.rb24cards.UseVisualStyleBackColor = true;
            this.rb24cards.CheckedChanged += new System.EventHandler(this.rb24cards_CheckedChanged);
            // 
            // rb16cards
            // 
            this.rb16cards.AutoSize = true;
            this.rb16cards.Location = new System.Drawing.Point(3, 5);
            this.rb16cards.Margin = new System.Windows.Forms.Padding(4);
            this.rb16cards.Name = "rb16cards";
            this.rb16cards.Size = new System.Drawing.Size(14, 13);
            this.rb16cards.TabIndex = 0;
            this.rb16cards.UseVisualStyleBackColor = true;
            this.rb16cards.CheckedChanged += new System.EventHandler(this.rb16cards_CheckedChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(192, 345);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(137, 35);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Fortsätt";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // tbNumberOfCards
            // 
            this.tbNumberOfCards.BackColor = System.Drawing.Color.LightGreen;
            this.tbNumberOfCards.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberOfCards.ForeColor = System.Drawing.Color.Black;
            this.tbNumberOfCards.Location = new System.Drawing.Point(219, 209);
            this.tbNumberOfCards.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumberOfCards.Name = "tbNumberOfCards";
            this.tbNumberOfCards.Size = new System.Drawing.Size(62, 24);
            this.tbNumberOfCards.TabIndex = 2;
            this.tbNumberOfCards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumberOfCards.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(461, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(21, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbtnCartoon
            // 
            this.rbtnCartoon.AutoSize = true;
            this.rbtnCartoon.Location = new System.Drawing.Point(3, 56);
            this.rbtnCartoon.Name = "rbtnCartoon";
            this.rbtnCartoon.Size = new System.Drawing.Size(14, 13);
            this.rbtnCartoon.TabIndex = 8;
            this.rbtnCartoon.UseVisualStyleBackColor = true;
            this.rbtnCartoon.Click += new System.EventHandler(this.rbtnCartoon_Click);
            // 
            // rbtnAnimals
            // 
            this.rbtnAnimals.AutoSize = true;
            this.rbtnAnimals.Location = new System.Drawing.Point(3, 34);
            this.rbtnAnimals.Name = "rbtnAnimals";
            this.rbtnAnimals.Size = new System.Drawing.Size(14, 13);
            this.rbtnAnimals.TabIndex = 7;
            this.rbtnAnimals.UseVisualStyleBackColor = true;
            this.rbtnAnimals.Click += new System.EventHandler(this.rbtnAnimals_Click);
            // 
            // rbtnFruit
            // 
            this.rbtnFruit.AutoSize = true;
            this.rbtnFruit.Location = new System.Drawing.Point(3, 12);
            this.rbtnFruit.Name = "rbtnFruit";
            this.rbtnFruit.Size = new System.Drawing.Size(14, 13);
            this.rbtnFruit.TabIndex = 7;
            this.rbtnFruit.UseVisualStyleBackColor = true;
            this.rbtnFruit.Click += new System.EventHandler(this.rbtnFruit_Click);
            // 
            // picBoxTheme
            // 
            this.picBoxTheme.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTheme.Image = global::MemoryCodeSamples.Properties.Resources.theme;
            this.picBoxTheme.Location = new System.Drawing.Point(41, 1);
            this.picBoxTheme.Name = "picBoxTheme";
            this.picBoxTheme.Size = new System.Drawing.Size(431, 363);
            this.picBoxTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTheme.TabIndex = 7;
            this.picBoxTheme.TabStop = false;
            this.picBoxTheme.Visible = false;
            // 
            // picBoxCardAmount
            // 
            this.picBoxCardAmount.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCardAmount.Image = global::MemoryCodeSamples.Properties.Resources.cardAmount;
            this.picBoxCardAmount.Location = new System.Drawing.Point(41, 1);
            this.picBoxCardAmount.Name = "picBoxCardAmount";
            this.picBoxCardAmount.Size = new System.Drawing.Size(431, 363);
            this.picBoxCardAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCardAmount.TabIndex = 9;
            this.picBoxCardAmount.TabStop = false;
            this.picBoxCardAmount.Visible = false;
            // 
            // picBoxCardAmountFree
            // 
            this.picBoxCardAmountFree.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCardAmountFree.Image = global::MemoryCodeSamples.Properties.Resources.cardAmountFree;
            this.picBoxCardAmountFree.Location = new System.Drawing.Point(41, 1);
            this.picBoxCardAmountFree.Name = "picBoxCardAmountFree";
            this.picBoxCardAmountFree.Size = new System.Drawing.Size(431, 363);
            this.picBoxCardAmountFree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCardAmountFree.TabIndex = 10;
            this.picBoxCardAmountFree.TabStop = false;
            this.picBoxCardAmountFree.Visible = false;
            // 
            // panelTheme
            // 
            this.panelTheme.BackColor = System.Drawing.Color.White;
            this.panelTheme.Controls.Add(this.rbtnAnimals);
            this.panelTheme.Controls.Add(this.rbtnFruit);
            this.panelTheme.Controls.Add(this.rbtnCartoon);
            this.panelTheme.Location = new System.Drawing.Point(181, 143);
            this.panelTheme.Name = "panelTheme";
            this.panelTheme.Size = new System.Drawing.Size(20, 81);
            this.panelTheme.TabIndex = 11;
            // 
            // panel1624
            // 
            this.panel1624.BackColor = System.Drawing.Color.White;
            this.panel1624.Controls.Add(this.rb16cards);
            this.panel1624.Controls.Add(this.rb24cards);
            this.panel1624.Location = new System.Drawing.Point(145, 132);
            this.panel1624.Name = "panel1624";
            this.panel1624.Size = new System.Drawing.Size(20, 45);
            this.panel1624.TabIndex = 12;
            // 
            // panel36free
            // 
            this.panel36free.BackColor = System.Drawing.Color.White;
            this.panel36free.Controls.Add(this.rbUsersChoice);
            this.panel36free.Controls.Add(this.rb36cards);
            this.panel36free.Location = new System.Drawing.Point(258, 132);
            this.panel36free.Name = "panel36free";
            this.panel36free.Size = new System.Drawing.Size(26, 45);
            this.panel36free.TabIndex = 13;
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryCodeSamples.Properties.Resources.rainbowSplashScreenBG1;
            this.ClientSize = new System.Drawing.Size(484, 393);
            this.Controls.Add(this.panel36free);
            this.Controls.Add(this.panel1624);
            this.Controls.Add(this.panelTheme);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.tbNumberOfCards);
            this.Controls.Add(this.picBoxCardAmountFree);
            this.Controls.Add(this.picBoxTheme);
            this.Controls.Add(this.picBoxCardAmount);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inställningar";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCardAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCardAmountFree)).EndInit();
            this.panelTheme.ResumeLayout(false);
            this.panelTheme.PerformLayout();
            this.panel1624.ResumeLayout(false);
            this.panel1624.PerformLayout();
            this.panel36free.ResumeLayout(false);
            this.panel36free.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb36cards;
        private System.Windows.Forms.RadioButton rb24cards;
        private System.Windows.Forms.RadioButton rb16cards;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbUsersChoice;
        private System.Windows.Forms.TextBox tbNumberOfCards;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbtnAnimals;
        private System.Windows.Forms.RadioButton rbtnFruit;
        private System.Windows.Forms.RadioButton rbtnCartoon;
        private System.Windows.Forms.PictureBox picBoxTheme;
        private System.Windows.Forms.PictureBox picBoxCardAmount;
        private System.Windows.Forms.PictureBox picBoxCardAmountFree;
        private System.Windows.Forms.Panel panelTheme;
        private System.Windows.Forms.Panel panel1624;
        private System.Windows.Forms.Panel panel36free;
    }
}