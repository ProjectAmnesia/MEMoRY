namespace MemoryCodeSamples
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
            this.components = new System.ComponentModel.Container();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.timerFlipBack = new System.Windows.Forms.Timer(this.components);
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerTimeTick = new System.Windows.Forms.Timer(this.components);
            this.playerTime_lbl = new System.Windows.Forms.Label();
            this.timerHaltComputer = new System.Windows.Forms.Timer(this.components);
            this.cbHuman = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlayer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAddPlayer.Location = new System.Drawing.Point(709, 5);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(181, 33);
            this.btnAddPlayer.TabIndex = 1;
            this.btnAddPlayer.Text = "Ny spelare";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayers.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPlayers.Location = new System.Drawing.Point(9, 86);
            this.lblPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(18, 20);
            this.lblPlayers.TabIndex = 3;
            this.lblPlayers.Text = "...";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTurn.Location = new System.Drawing.Point(8, 9);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(18, 20);
            this.lblTurn.TabIndex = 3;
            this.lblTurn.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spelare och poäng:";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.LightBlue;
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPlayAgain.Location = new System.Drawing.Point(803, 684);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPlayAgain.Size = new System.Drawing.Size(87, 37);
            this.btnPlayAgain.TabIndex = 6;
            this.btnPlayAgain.Text = "Spela igen";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // timerFlipBack
            // 
            this.timerFlipBack.Interval = 1000;
            this.timerFlipBack.Tick += new System.EventHandler(this.timerFlipBack_Tick);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelGame.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGame.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnCancelGame.Location = new System.Drawing.Point(710, 684);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(87, 37);
            this.btnCancelGame.TabIndex = 7;
            this.btnCancelGame.Text = "Avsluta";
            this.btnCancelGame.UseVisualStyleBackColor = false;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.cbHuman);
            this.groupBox1.Controls.Add(this.lblTurn);
            this.groupBox1.Controls.Add(this.lblPlayers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(709, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 634);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // PlayerTimeTick
            // 
            this.PlayerTimeTick.Interval = 1000;
            // 
            // playerTime_lbl
            // 
            this.playerTime_lbl.AutoSize = true;
            this.playerTime_lbl.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTime_lbl.Location = new System.Drawing.Point(766, 439);
            this.playerTime_lbl.Name = "playerTime_lbl";
            this.playerTime_lbl.Size = new System.Drawing.Size(0, 29);
            this.playerTime_lbl.TabIndex = 7;
            // 
            // timerHaltComputer
            // 
            this.timerHaltComputer.Interval = 300;
            this.timerHaltComputer.Tick += new System.EventHandler(this.timerHaltComputer_Tick);
            // 
            // cbHuman
            // 
            this.cbHuman.AutoSize = true;
            this.cbHuman.Checked = true;
            this.cbHuman.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHuman.Location = new System.Drawing.Point(94, 22);
            this.cbHuman.Name = "cbHuman";
            this.cbHuman.Size = new System.Drawing.Size(70, 18);
            this.cbHuman.TabIndex = 6;
            this.cbHuman.Text = "Human";
            this.cbHuman.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryCodeSamples.Properties.Resources.rainbowMain1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(895, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.playerTime_lbl);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnAddPlayer);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Timer timerFlipBack;
        private System.Windows.Forms.Button btnCancelGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer PlayerTimeTick;
        private System.Windows.Forms.Label playerTime_lbl;
        private System.Windows.Forms.Timer timerHaltComputer;
        private System.Windows.Forms.CheckBox cbHuman;


    }
}

