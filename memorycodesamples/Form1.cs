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

        // SOUND Objects
        Sounds SoundCollection = new Sounds();
        GameSettings game = new GameSettings();
        End frm = new End();
        int numberOfCards = 16;
        Board board;
        int playersTurn;
        bool gameStarted = false;
        Card lastFlipped;
        Card clickedCard;
        Computer c;
        int flippedCards;
        //int usedCards = 0;
        int themeNum = 0;
        List<Player> players = new List<Player>();
        public string[] playerNamesVec = new string[8] { "T-rex", "Häst", "Enhörning", "Snigel", "Haj", "Igelkott", "Delfin", "Giraff" };


        public Form1()
        {
            InitializeComponent();
            StartGame();
            SoundCollection.IntroSound();   // add to splash screen
        }

        private void UpdateGUI()
        {
            //btnAddPlayer.Enabled = (usedCards != 0) ? false : true;
            string info = "";
            foreach (Player p in players)
            {
                if (p is Computer)
                    info += p.name + ", dator\n" + p.points + " poäng\n";
                else
                    info += p.name + ",\n" + p.points + " poäng\n";//mmm
            }

            lblPlayers.Text = info;
            if (gameStarted && players.Count > 1)
                lblTurn.Text = "Nu är det din tur:\n" + players[playersTurn].name;
        }

        private void StartGame()
        {
            DialogResult dialog = game.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                numberOfCards = game.EnteredNumberOfCards();
                themeNum = game.ChooseTheme();
            }
            else { }
        }

        private void NewBoard()
        {
            board = new Board(numberOfCards, this.card_Click);
            board.Location = new System.Drawing.Point(0, 0);
            this.Controls.Add(board);
            //timerDrawTime.Interval = game.ChooseTime();
        }

        private void FlipAllCards()
        {
            //usedCards = 0;
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

        private void NextPlayer()
        {
            playersTurn++;
            flippedCards = 0;
            if (playersTurn >= players.Count)
            {
                playersTurn = 0;
            }
        }

        private void ResetGame()
        {
            FlipAllCards();
            board.CreateNewGame(numberOfCards, themeNum);
            foreach (var player in players)
            {
                player.points = 0;
            }
            UpdateGUI();
        }

        private void FindWinner()
        {
            Player maxItem = players.OrderByDescending(obj => obj.points).First();
            List<Player> lista = players.FindAll(obj => obj.points == maxItem.points);

            if (lista.Count > 1)
                frm.Winner = "Det blev oavgjort";
            else
                frm.Winner = maxItem.name;
            frm.ShowWinner();
        }

        private void EndingGame()
        {
            FindWinner();
            this.Hide();
            SoundCollection.WinnerSound();
            DialogResult dialog = frm.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                ResetGame();
                this.Show();
            }
        }
        private void MatchedCards()
        {
            SoundCollection.PairSound();
            players[playersTurn].points++;
            playersTurn--;
            clickedCard.Disable();
            lastFlipped.Disable();
            c.RemoveCardFromComputerMemory(lastFlipped);
            c.RemoveCardFromComputerMemory(clickedCard);
        }
        private void card_Click(object sender, EventArgs e)
        {
            if (flippedCards == 0)
            {
                FlipAllPlayableCards();
            }
            timerFlipBack.Enabled = false;
            timerDrawTime.Enabled = false;
            clickedCard = (Card)sender;
            clickedCard.Flipped = !clickedCard.Flipped;
            flippedCards++;
            if (flippedCards == 1)
            {
                timerDrawTime.Enabled = true;
            }
            else if (flippedCards == 2)
            {
                c.HandleComputerMemory(clickedCard);
                c.HandleComputerMemory(lastFlipped);
                timerDrawTime.Enabled = false;
                timerFlipBack.Enabled = true;
                if (clickedCard.Match(lastFlipped))
                {
                    MatchedCards();
                }
                NextPlayer();
                var usedCards = board.cardList.FindAll(x => !x.Playable);
                if (usedCards.Count == board.cardList.Count)
                {
                    EndingGame();
                }
            }
            lastFlipped = clickedCard;
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
            NextPlayer();
            timerDrawTime.Enabled = false;
            UpdateGUI();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            players.Add(human);
            human.name = playerNamesVec[players.Count - 1];
            UpdateGUI();
        }

        private void btnAIeasy_Click(object sender, EventArgs e)
        {
            Computer comp = new Computer(3);
            players.Add(comp);
            comp.name = playerNamesVec[players.Count - 1];
            UpdateGUI();
        }

        private void btnAImedium_Click(object sender, EventArgs e)
        {

        }

        private void btnAIhard_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            gameStarted = true;
            btnAddPlayer.Visible = false;
            btnAIeasy.Visible = false;
            btnAIhard.Visible = false;
            btnAImedium.Visible = false;
            btnPlay.Visible = false;
            lblAddAI.Visible = false;
            NewBoard();
            UpdateGUI();
            board.CreateNewGame(numberOfCards, themeNum);

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

    }
}



