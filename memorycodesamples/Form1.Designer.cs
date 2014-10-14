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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.timerFlipBack = new System.Windows.Forms.Timer(this.components);
            this.timerDrawTime = new System.Windows.Forms.Timer(this.components);
            this.btnAddAI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.Location = new System.Drawing.Point(706, 27);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(124, 25);
            this.btnAddPlayer.TabIndex = 1;
            this.btnAddPlayer.Text = "Ny spelare";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(700, 189);
            this.lblPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(0, 14);
            this.lblPlayers.TabIndex = 3;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(700, 101);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 14);
            this.lblTurn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spelare och poäng:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(730, 429);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 37);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "Nytt spel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(730, 468);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPlayAgain.Size = new System.Drawing.Size(100, 37);
            this.btnPlayAgain.TabIndex = 6;
            this.btnPlayAgain.Text = "Spela igen";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // timerFlipBack
            // 
            this.timerFlipBack.Interval = 1000;
            this.timerFlipBack.Tick += new System.EventHandler(this.timerFlipBack_Tick);
            // 
            // timerDrawTime
            // 
            this.timerDrawTime.Interval = 3000;
            this.timerDrawTime.Tick += new System.EventHandler(this.timerDrawTime_Tick);
            // 
            // btnAddAI
            // 
            this.btnAddAI.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAI.Location = new System.Drawing.Point(706, 58);
            this.btnAddAI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddAI.Name = "btnAddAI";
            this.btnAddAI.Size = new System.Drawing.Size(124, 25);
            this.btnAddAI.TabIndex = 1;
            this.btnAddAI.Text = "Ny AI";
            this.btnAddAI.UseVisualStyleBackColor = true;
            this.btnAddAI.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lägg till spelare:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.btnAddAI);
            this.Controls.Add(this.btnAddPlayer);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Timer timerFlipBack;
        private System.Windows.Forms.Timer timerDrawTime;
        private System.Windows.Forms.Button btnAddAI;
        private System.Windows.Forms.Label label1;


    }
}

