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
        Sounds SoundCollection = new Sounds();
        GameSettings game = new GameSettings();
        End endForm = new End();
        int numberOfCards = 16;
        Board board;
        int playersTurn;
        bool gameStarted = false;
        Card lastFlipped;
        Card clickedCard;
        int flippedCards;
        int themeNum = 0;
        List<Player> players = new List<Player>();
        public string[] playerNamesVec = new string[8] { "T-rex", "Häst", "Enhörning", "Snigel", "Haj", "Igelkott", "Delfin", "Giraff" };


        public Form1()
        {
            InitializeComponent();

            StartGame();

            SoundCollection.IntroSound();
        }

        private bool ComputerPlaying
        {
            get
            {
                return players[playersTurn] is Computer;
            }
        }

        private void UpdateGUI()
        {
            string info = "";
            foreach (Player p in players)
            {
                if (p is Computer)
                    info += p.name + ", dator " + p.diff + "\n" + p.points + " poäng\n";
                else
                    info += p.name + ",\n" + p.points + " poäng\n";
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
        }

        private void NewBoard()
        {
            board = new Board(numberOfCards, this.card_Click);
            board.Location = new System.Drawing.Point(0, 0);
            this.Controls.Add(board);

            foreach (Player player in players)
            {
                if (player is Computer)
                {
                    ((Computer)player).CardsOnBoard(board.cardList);
                }
            }
        }

        private void FlipAllCards()
        {
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

            if (players[playersTurn] is Computer)
            {
                timerComputerTick.Enabled = true;
            }

            UpdateGUI();
        }

        private void RestartGame()
        {
            board.CreateNewGame(numberOfCards, themeNum);
            playersTurn = 0;
            foreach (var player in players)
            {
                player.points = 0;
                if (player is Computer)
                {
                    Computer computer = (Computer)player;
                    computer.CardsOnBoard(board.cardList);
                    computer.ResetMemory();
                }
            }
            if (players[playersTurn] is Computer)
            {
                timerComputerTick.Enabled = true;                
            }
            UpdateGUI();
        }

        private void FindWinner()
        {
            Player maxItem = players.OrderByDescending(obj => obj.points).First();
            List<Player> lista = players.FindAll(obj => obj.points == maxItem.points);

            if (lista.Count > 1)
            {
                endForm.Winner = "Det blev oavgjort";
            }
            else
            {
                endForm.Winner = maxItem.name;
            }
            endForm.ShowWinner();
        }

        private void EndGame()
        {
            FindWinner();
            this.Hide();
            SoundCollection.WinnerSound();
            DialogResult dialog = endForm.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                RestartGame();
                this.Show();
            }
        }
        private void MatchedCards()
        {
            SoundCollection.PairSound();
            players[playersTurn].points++;
            clickedCard.Disable();
            lastFlipped.Disable();
        }

        // AI events:

        private void ComputerDidFindMatch(Card cardOne, Card cardTwo, Computer computer)
        {
            cardOne.Flipped = true;
            cardTwo.Flipped = true;

            cardOne.Disable();
            cardTwo.Disable();

            computer.points++;

            SoundCollection.PairSound();

            timerComputerTick.Enabled = true;

            UpdateGUI();
        }

        private void ComputerDidNotFindMatch(Card cardOne, Card cardTwo, Computer computer)
        {
            cardOne.Flipped = true;
            cardTwo.Flipped = true;

            AddToComputerMemory(cardOne, cardTwo);

            cardOne.Refresh();
            cardTwo.Refresh();

            timerFlipBackCards.Enabled = true;

        }

        private void AddComputer(Level level)
        {
            Computer computer = new Computer(level);
            players.Add(computer);
            if (level == Level.Easy)
                computer.diff = "lätt";
            else if (level == Level.Medium)
                computer.diff = "medel";
            else
                computer.diff = "svår";
            computer.name = playerNamesVec[players.Count - 1];
            computer.DidFindMatchingCards += this.ComputerDidFindMatch;
            computer.DidNotFindMatchingCards += this.ComputerDidNotFindMatch;
            UpdateGUI();
        }

        // Button events:

        private void card_Click(object sender, EventArgs e)
        {
            if (ComputerPlaying)
            {
                return;
            }
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
                timerDrawTime.Enabled = false;
                timerFlipBack.Enabled = true;
                flippedCards = 0;
                if (clickedCard.Match(lastFlipped))
                {
                    MatchedCards();
                }
                else
                {
                    NextPlayer();
                }

                if (DidGameEnd())
                {
                    EndGame();
                }
                else
                {
                    AddToComputerMemory(clickedCard, lastFlipped);

                }
            }
            lastFlipped = clickedCard;
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
            AddComputer(Level.Easy);
        }

        private void btnAImedium_Click(object sender, EventArgs e)
        {
            AddComputer(Level.Medium);
        }

        private void btnAIhard_Click(object sender, EventArgs e)
        {
            AddComputer(Level.Hard);
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
            board.CreateNewGame(numberOfCards, themeNum);
            UpdateGUI();

            if (players[playersTurn] is Computer)
            {
                timerComputerTick.Enabled = true;
            }
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
            RestartGame();
        }

        private bool DidGameEnd()
        {
            var usedCards = board.cardList.FindAll(x => !x.Playable);
            return usedCards.Count == board.cardList.Count;
        }

        private void AddToComputerMemory(params Card[] cards)
        {
            foreach (Player player in players)
            {
                if (player is Computer)
                {
                    foreach (Card c in cards)
                    {
                        ((Computer)player).AddToComputerMemory(c);
                    }
                }
            }
        }

        // Timers:

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

        private void timerComputerTick_Tick(object sender, EventArgs e)
        {
            timerComputerTick.Enabled = false;

            if (DidGameEnd())
            {
                EndGame();
            }
            else if (players[playersTurn] is Computer && !DidGameEnd())
            {
                ((Computer)players[playersTurn]).Play();
            }
        }

        private void timerFlipBackCards_Tick(object sender, EventArgs e)
        {
            timerFlipBackCards.Enabled = false;
            FlipAllPlayableCards();
            NextPlayer();
        }

    }
}



