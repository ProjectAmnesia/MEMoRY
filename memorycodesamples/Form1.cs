﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCodeSamples
{
    public partial class Form1 : Form
    {
        int seconds = 30;
        int numberOfCards = 16;
        Board board;
        int playersTurn;
        bool gameStarted = false;
        Card lastFlipped;
        int flippedCards;
        int usedCards = 0;
        List<Player> players = new List<Player>();
        public string[] playerNamesVec = new string[8] {"T-rex", "Häst", "Enhörning","Snigel", "Haj","Igelkott","Delfin","Giraff"};

        public Form1()
        {
            InitializeComponent();
            NewBoard();
            StartGame();
        }

        private void UpdateGUI()
        {
            btnAddPlayer.Enabled = (usedCards != 0) ? false : true;
           
            string info = "";
            foreach (Player p in players)
            {
                info += p.name + ", " + p.points + " poäng\n";
            }
            lblPlayers.Text = info;
            if (gameStarted && players.Count() > 1)
                lblTurn.Text = "Nu är det din tur:\n" + players[playersTurn].name;
        }

        private void StartGame()
        {
            GameSettings game = new GameSettings();
            DialogResult dialog = game.ShowDialog();            
            if (dialog == DialogResult.OK)
            {
                numberOfCards = game.EnteredNumberOfCards();
            }
            else
            {
                this.Close();
            }
            board.CreateNewGame(numberOfCards);
            gameStarted = true;
        }

        private void NewBoard()
        {
            board = new Board(numberOfCards, this.card_Click);
            board.Location = new System.Drawing.Point(0, 0);
            this.Controls.Add(board);
        }

        private void FlipAllCards()
        {
            usedCards = 0;
            foreach (var card in board.cardList)
            {
                card.Flipped = false;
                card.Enabled = true;
            }
        }

        private void FlipAllPlayableCards()
        {
            foreach (var card in board.cardList)
            {
                if (card.Playable)
                {
                    card.Flipped = false;
                }
            }
        }
 
        private void IncrementPlayer()
        {
            playersTurn++;
            flippedCards = 0;
            if (playersTurn >= players.Count)
            {
                playersTurn = 0;
            }
        }

        

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            FlipAllCards();
            board.CreateNewGame(numberOfCards);
            foreach (var player in players)
            {
                player.points = 0;
            }
            UpdateGUI();
        }

        private void card_Click(object sender, EventArgs e)
        {
            if (players.Count < 1)
                return;
            if (flippedCards == 0)
            {
                FlipAllPlayableCards();
            }
            timerFlipBack.Enabled = false;
            timerDrawTime.Enabled = false;
            Card clickedCard = (Card)sender;
            clickedCard.Flipped = !clickedCard.Flipped;
            flippedCards++;
            usedCards++;

            if (flippedCards == 1)
            {
                //timerDrawTime.Enabled = true;
                PlayerTimeTick.Enabled = true; 
            }
            else if (flippedCards == 2)
            {
                timerDrawTime.Enabled = false;
                PlayerTimeTick.Enabled = false;
                ResetTimer();
                timerFlipBack.Enabled = true;
                if (clickedCard.Match(lastFlipped))
                {
                    players[playersTurn].points++;
                    playersTurn--;
                    clickedCard.Disable();
                    lastFlipped.Disable();
                }
                IncrementPlayer();
                var notsmart = board.cardList.FindAll(x => !x.Playable);
                if(notsmart.Count() == board.cardList.Count())
                {
                    Player maxItem = players.OrderByDescending(obj => obj.points).First();
                    

                    End frm = new End();
                    frm.winner = maxItem.name;
                    frm.Show();

                    this.Hide();
                   
                }
            }
            lastFlipped = clickedCard;
            UpdateGUI();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

            Human human = new Human("");
            players.Add(human);
            human.name = playerNamesVec[players.Count - 1];
            UpdateGUI();

        }

        private void timerFlipBack_Tick(object sender, EventArgs e)
        {
            FlipAllPlayableCards();
            timerFlipBack.Enabled = false;
            UpdateGUI();            
        }

        private void timerDrawTime_Tick(object sender, EventArgs e)
        {
            FlipAllPlayableCards();
            lastFlipped = null;
            IncrementPlayer();
            timerDrawTime.Enabled = false;      
            UpdateGUI();            
        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayerTimeOnClick_Tick(object sender, EventArgs e)
        {   // tick intervall set to 1000 ms
            seconds--;
            playerTime_lbl.Text = seconds.ToString();
            if (seconds == 0) // when time hits 0 do below
            {
                PlayerTimeTick.Enabled = false; // turn of timer tick so while code is run to remove issues
                MessageBox.Show("TIme is up, Next player");
                FlipAllPlayableCards(); // flip cards back
                IncrementPlayer();     // force change of player
                UpdateGUI();           // update score & player so right players turn is shown
                ResetTimer();          // Restore values for workable loop

            }
        }
        public void ResetTimer()
        {
            seconds = 30; // hard coded can make int variable to make it dynamic
            playerTime_lbl.Text = "";
        }

       

       
    }
}
