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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUsersChoice = new System.Windows.Forms.RadioButton();
            this.rb36cards = new System.Windows.Forms.RadioButton();
            this.rb24cards = new System.Windows.Forms.RadioButton();
            this.rb16cards = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbNumberOfCards = new System.Windows.Forms.TextBox();
            this.lblCards = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.grbxTheme = new System.Windows.Forms.GroupBox();
            this.rbT1 = new System.Windows.Forms.RadioButton();
            this.rbT2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grbxTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUsersChoice);
            this.groupBox1.Controls.Add(this.rb36cards);
            this.groupBox1.Controls.Add(this.rb24cards);
            this.groupBox1.Controls.Add(this.rb16cards);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(165, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antal kort";
            // 
            // rbUsersChoice
            // 
            this.rbUsersChoice.AutoSize = true;
            this.rbUsersChoice.Location = new System.Drawing.Point(9, 88);
            this.rbUsersChoice.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsersChoice.Name = "rbUsersChoice";
            this.rbUsersChoice.Size = new System.Drawing.Size(123, 20);
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
            this.rb36cards.Size = new System.Drawing.Size(73, 20);
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
            this.rb24cards.Size = new System.Drawing.Size(73, 20);
            this.rb24cards.TabIndex = 0;
            this.rb24cards.Text = "24 kort";
            this.rb24cards.UseVisualStyleBackColor = true;
            // 
            // rb16cards
            // 
            this.rb16cards.AutoSize = true;
            this.rb16cards.Checked = true;
            this.rb16cards.Location = new System.Drawing.Point(9, 22);
            this.rb16cards.Margin = new System.Windows.Forms.Padding(4);
            this.rb16cards.Name = "rb16cards";
            this.rb16cards.Size = new System.Drawing.Size(73, 20);
            this.rb16cards.TabIndex = 0;
            this.rb16cards.TabStop = true;
            this.rb16cards.Text = "16 kort";
            this.rb16cards.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPlay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(223, 126);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(117, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Börja spela!";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // tbNumberOfCards
            // 
            this.tbNumberOfCards.Location = new System.Drawing.Point(28, 164);
            this.tbNumberOfCards.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumberOfCards.Name = "tbNumberOfCards";
            this.tbNumberOfCards.Size = new System.Drawing.Size(116, 22);
            this.tbNumberOfCards.TabIndex = 2;
            this.tbNumberOfCards.Visible = false;
            // 
            // lblCards
            // 
            this.lblCards.AutoSize = true;
            this.lblCards.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCards.Location = new System.Drawing.Point(48, 144);
            this.lblCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(77, 14);
            this.lblCards.TabIndex = 3;
            this.lblCards.Text = "Antal kort:";
            this.lblCards.Visible = false;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(46, 194);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(81, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "(max 120 st)";
            this.lblMax.Visible = false;
            // 
            // grbxTheme
            // 
            this.grbxTheme.Controls.Add(this.rbT2);
            this.grbxTheme.Controls.Add(this.rbT1);
            this.grbxTheme.Location = new System.Drawing.Point(216, 24);
            this.grbxTheme.Name = "grbxTheme";
            this.grbxTheme.Size = new System.Drawing.Size(136, 64);
            this.grbxTheme.TabIndex = 4;
            this.grbxTheme.TabStop = false;
            this.grbxTheme.Text = "Välj tema";
            // 
            // rbT1
            // 
            this.rbT1.AutoSize = true;
            this.rbT1.Checked = true;
            this.rbT1.Location = new System.Drawing.Point(7, 22);
            this.rbT1.Name = "rbT1";
            this.rbT1.Size = new System.Drawing.Size(70, 18);
            this.rbT1.TabIndex = 0;
            this.rbT1.TabStop = true;
            this.rbT1.Text = "Tema 1";
            this.rbT1.UseVisualStyleBackColor = true;
            // 
            // rbT2
            // 
            this.rbT2.AutoSize = true;
            this.rbT2.Location = new System.Drawing.Point(6, 44);
            this.rbT2.Name = "rbT2";
            this.rbT2.Size = new System.Drawing.Size(70, 18);
            this.rbT2.TabIndex = 0;
            this.rbT2.TabStop = true;
            this.rbT2.Text = "Tema 2";
            this.rbT2.UseVisualStyleBackColor = true;
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 226);
            this.Controls.Add(this.grbxTheme);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblCards);
            this.Controls.Add(this.tbNumberOfCards);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inställningar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxTheme.ResumeLayout(false);
            this.grbxTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb36cards;
        private System.Windows.Forms.RadioButton rb24cards;
        private System.Windows.Forms.RadioButton rb16cards;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbUsersChoice;
        private System.Windows.Forms.TextBox tbNumberOfCards;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox grbxTheme;
        private System.Windows.Forms.RadioButton rbT2;
        private System.Windows.Forms.RadioButton rbT1;
    }
}