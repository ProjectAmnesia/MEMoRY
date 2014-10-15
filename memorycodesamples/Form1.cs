using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MemoryCodeSamples
{
    public partial class Form1 : Form
    {
        int numberOfCards = 16;
        Board board;
        int playersTurn;
        bool gameStarted = false;
        Card lastFlipped;
        int flippedCards;
        int usedCards = 0;
        List<Player> players = new List<Player>();
        Computer computerPlayer1 = new Computer(6);
        Computer computerPlayer2 = new Computer(6);
        public Form1()
        {
            InitializeComponent();
            players.Add(computerPlayer1);
            players.Add(computerPlayer2);
            NewBoard();
            StartGame();
        }

        private void UpdateGUI()
        {
            btnAddPlayer.Enabled = (usedCards != 0) ? false : true;
            tbxPlayerName.Clear();
            string info = "";
            foreach (Player p in players)
            {
                info += p.name + ", " + p.points + " poäng\n";
            }
            lblPlayers.Text = info;
            if (gameStarted && players.Count() > 1)
                lblTurn.Text = "Nu är det din tur: " + players[playersTurn].name;
        }

        private void StartGame()
        {
            //GameSettings game = new GameSettings();
            //DialogResult dialog = game.ShowDialog();
            //if (dialog == DialogResult.OK)
            //{
            //    numberOfCards = game.EnteredNumberOfCards();
            //}
            board.CreateNewGame(numberOfCards);
            gameStarted = true;
            computerPlayer1.allCardsOnBoard = board.cardList;
            computerPlayer2.allCardsOnBoard = board.cardList;
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

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
            FlipAllCards();
            players.Clear();
            UpdateGUI();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            FlipAllCards();
            board.CreateNewGame(numberOfCards);
            foreach (var player in players)
            {
                player.points = 0;
                if(player is Computer)
                {
                    ((Computer)player).ResetMemory();
                    ((Computer)player).allCardsOnBoard = board.cardList;
                }
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
                timerDrawTime.Enabled = true;
            }
            else if (flippedCards == 2)
            {
                timerDrawTime.Enabled = false;
                timerFlipBack.Enabled = true;
                if (clickedCard.Match(lastFlipped))
                {
                    lastFlipped.Disable();
                    clickedCard.Disable();
                    players[playersTurn].points++;
                    playersTurn--;
                }
                else
                {
                    //computerPlayer.HandleComputerMemory(clickedCard);
                    //computerPlayer.HandleComputerMemory(lastFlipped);
                }
                IncrementPlayer();
                var notsmart = board.cardList.FindAll(x => !x.Playable);
                if(notsmart.Count() == board.cardList.Count())
                {
                    Player maxItem = players.OrderByDescending(obj => obj.points).First();
                    MessageBox.Show("Grattis " + maxItem.name + "!");
                }
            }
            lastFlipped = clickedCard;
            UpdateGUI();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Human human = new Human(tbxPlayerName.Text);
            players.Add(human);
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            var notsmart = board.cardList.FindAll(x => !x.Playable);
            while(notsmart.Count < numberOfCards -1)
            {
                computerPlayer1.ComputerTurn();
                computerPlayer2.HandleComputerMemory(computerPlayer1.firstCard);
                computerPlayer2.HandleComputerMemory(computerPlayer1.secondCard);
                foreach(Card c in board.cardList)
                {
                    c.Refresh();
                }
                Thread.Sleep(500);
                computerPlayer2.ComputerTurn();
                computerPlayer1.HandleComputerMemory(computerPlayer2.firstCard);
                computerPlayer1.HandleComputerMemory(computerPlayer2.secondCard);
                foreach (Card c in board.cardList)
                {
                    c.Refresh();
                }
                Thread.Sleep(500);
            }
            
            
        }
       
    }
}
