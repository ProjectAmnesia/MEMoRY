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
            this.timerDrawTime = new System.Windows.Forms.Timer(this.components);
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerComputerTick = new System.Windows.Forms.Timer(this.components);
            this.playerTime_lbl = new System.Windows.Forms.Label();
            this.btnAIeasy = new System.Windows.Forms.Button();
            this.btnAImedium = new System.Windows.Forms.Button();
            this.btnAIhard = new System.Windows.Forms.Button();
            this.lblAddAI = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.timerFlipBackCards = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlayer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAddPlayer.Location = new System.Drawing.Point(388, 207);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(129, 33);
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
            this.lblPlayers.Size = new System.Drawing.Size(24, 26);
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
            this.lblTurn.Size = new System.Drawing.Size(24, 26);
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
            this.label2.Size = new System.Drawing.Size(177, 26);
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
            // timerDrawTime
            // 
            this.timerDrawTime.Interval = 9000;
            this.timerDrawTime.Tick += new System.EventHandler(this.timerDrawTime_Tick);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelGame.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelGame.ForeColor = System.Drawing.Color.Red;
            this.btnCancelGame.Location = new System.Drawing.Point(848, 1);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(42, 37);
            this.btnCancelGame.TabIndex = 7;
            this.btnCancelGame.Text = "X";
            this.btnCancelGame.UseVisualStyleBackColor = false;
            this.btnCancelGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.lblTurn);
            this.groupBox1.Controls.Add(this.lblPlayers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(709, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 634);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // timerComputerTick
            // 
            this.timerComputerTick.Interval = 2000;
            this.timerComputerTick.Tick += new System.EventHandler(this.timerComputerTick_Tick);
            // 
            // playerTime_lbl
            // 
            this.playerTime_lbl.AutoSize = true;
            this.playerTime_lbl.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTime_lbl.Location = new System.Drawing.Point(766, 439);
            this.playerTime_lbl.Name = "playerTime_lbl";
            this.playerTime_lbl.Size = new System.Drawing.Size(0, 36);
            this.playerTime_lbl.TabIndex = 7;
            // 
            // btnAIeasy
            // 
            this.btnAIeasy.BackColor = System.Drawing.Color.LightBlue;
            this.btnAIeasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAIeasy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAIeasy.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAIeasy.Location = new System.Drawing.Point(358, 269);
            this.btnAIeasy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAIeasy.Name = "btnAIeasy";
            this.btnAIeasy.Size = new System.Drawing.Size(54, 26);
            this.btnAIeasy.TabIndex = 1;
            this.btnAIeasy.Text = "Lätt";
            this.btnAIeasy.UseVisualStyleBackColor = false;
            this.btnAIeasy.Click += new System.EventHandler(this.btnAIeasy_Click);
            // 
            // btnAImedium
            // 
            this.btnAImedium.BackColor = System.Drawing.Color.LightBlue;
            this.btnAImedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAImedium.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAImedium.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAImedium.Location = new System.Drawing.Point(426, 269);
            this.btnAImedium.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAImedium.Name = "btnAImedium";
            this.btnAImedium.Size = new System.Drawing.Size(54, 26);
            this.btnAImedium.TabIndex = 1;
            this.btnAImedium.Text = "Medel";
            this.btnAImedium.UseVisualStyleBackColor = false;
            this.btnAImedium.Click += new System.EventHandler(this.btnAImedium_Click);
            // 
            // btnAIhard
            // 
            this.btnAIhard.BackColor = System.Drawing.Color.LightBlue;
            this.btnAIhard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAIhard.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAIhard.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAIhard.Location = new System.Drawing.Point(494, 269);
            this.btnAIhard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAIhard.Name = "btnAIhard";
            this.btnAIhard.Size = new System.Drawing.Size(54, 26);
            this.btnAIhard.TabIndex = 1;
            this.btnAIhard.Text = "Svår";
            this.btnAIhard.UseVisualStyleBackColor = false;
            this.btnAIhard.Click += new System.EventHandler(this.btnAIhard_Click);
            // 
            // lblAddAI
            // 
            this.lblAddAI.AutoSize = true;
            this.lblAddAI.BackColor = System.Drawing.Color.Transparent;
            this.lblAddAI.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAddAI.Location = new System.Drawing.Point(385, 252);
            this.lblAddAI.Name = "lblAddAI";
            this.lblAddAI.Size = new System.Drawing.Size(159, 18);
            this.lblAddAI.TabIndex = 9;
            this.lblAddAI.Text = "Spela mot en dator:";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightBlue;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPlay.Location = new System.Drawing.Point(456, 301);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(104, 33);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Starta spelet";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.LightBlue;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnNewGame.Location = new System.Drawing.Point(710, 684);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNewGame.Size = new System.Drawing.Size(87, 37);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "Nytt spel";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // timerFlipBackCards
            // 
            this.timerFlipBackCards.Interval = 1000;
            this.timerFlipBackCards.Tick += new System.EventHandler(this.timerFlipBackCards_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryCodeSamples.Properties.Resources.rainbowMain1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(895, 733);
            this.Controls.Add(this.lblAddAI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.playerTime_lbl);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAIhard);
            this.Controls.Add(this.btnAImedium);
            this.Controls.Add(this.btnAIeasy);
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
        private System.Windows.Forms.Timer timerDrawTime;
        private System.Windows.Forms.Button btnCancelGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerComputerTick;
        private System.Windows.Forms.Label playerTime_lbl;
        private System.Windows.Forms.Button btnAIeasy;
        private System.Windows.Forms.Button btnAImedium;
        private System.Windows.Forms.Button btnAIhard;
        private System.Windows.Forms.Label lblAddAI;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer timerFlipBackCards;


    }
}

