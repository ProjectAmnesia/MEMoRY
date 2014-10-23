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
        int flippedCards;
        //int usedCards = 0;
        int themeNum;
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
                if (p is ComputerTwo)
                    info += p.name + ", dator " + p.diff +"\n" + p.points + " poäng\n";
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
            else { }
        }

        private void NewBoard()
        {
            board = new Board(numberOfCards, this.card_Click);
            board.Location = new System.Drawing.Point(0, 0);
            this.Controls.Add(board);
            foreach (Player player in players)
            {
                if (player is ComputerTwo)
                {
                    ((ComputerTwo)player).CardsOnBoard(board.cardList);
                }
            }
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

            if (players[playersTurn] is ComputerTwo)
            {
                timerComputerTick.Enabled = true;                
            }

            UpdateGUI();
        }

        private void ResetGame()
        {
            FlipAllCards();
            board.CreateNewGame(numberOfCards, themeNum);
            foreach (var player in players)
            {
                player.points = 0;
            }
            foreach (Player player in players)
            {
                if(player is ComputerTwo)
                {
                    ((ComputerTwo)player).CardsOnBoard(board.cardList);
                }
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
        }

        private bool IsFirstPlayerAI()
        {
            if (players[playersTurn] is ComputerTwo)
                return true;
            else
                return false;
        }

        private void card_Click(object sender, EventArgs e)
        {
            //if (flippedCards == 0)
            //{
            //    FlipAllPlayableCards();
            //}
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
                if (clickedCard.Match(lastFlipped))
                {
                    MatchedCards();
                }
                if (DidGameEnd())
                {
                    EndingGame();
                }
                else
                {
                    foreach (Player player in players)
                    {
                        if (player is ComputerTwo)
                        {
                            ((ComputerTwo)player).AddToComputerMemory(clickedCard);
                            ((ComputerTwo)player).AddToComputerMemory(lastFlipped);
                        }
                    }
                    NextPlayer();
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
            ComputerTwo computer = new ComputerTwo(numberOfCards/4);
            players.Add(computer);
            computer.diff = "lätt";
            computer.name = playerNamesVec[players.Count - 1];
            computer.DidFindMatchingCards += this.ComputerDidFindMatch;
            computer.DidNotFindMatchingCards += this.ComputerDidNotFindMatch;

            UpdateGUI();

        }

        private void ComputerDidFindMatch(Card cardOne, Card cardTwo, ComputerTwo computer)
        {
            cardOne.Flipped = true;
            cardTwo.Flipped = true;

            cardOne.Disable();
            cardTwo.Disable();

            computer.points++;

            SoundCollection.PairSound();

            if (DidGameEnd())
            {
                EndingGame();
            }
            else
            {
                Thread.Sleep(1000);
                computer.Play();
            }
            UpdateGUI();
        }

        private void ComputerDidNotFindMatch(Card cardOne, Card cardTwo, ComputerTwo computer)
        {

            cardOne.Flipped = true;
            cardTwo.Flipped = true;

            cardOne.Refresh();
            cardTwo.Refresh();

            Thread.Sleep(1500);

            FlipAllPlayableCards();

            NextPlayer();
        }

        private void btnAImedium_Click(object sender, EventArgs e)
        {
            ComputerTwo computerMedium = new ComputerTwo(numberOfCards/3);
            players.Add(computerMedium);
            computerMedium.diff = "medel";
            computerMedium.name = playerNamesVec[players.Count - 1];
            computerMedium.DidFindMatchingCards += this.ComputerDidFindMatch;
            computerMedium.DidNotFindMatchingCards += this.ComputerDidNotFindMatch;
            UpdateGUI();
        }

        private void btnAIhard_Click(object sender, EventArgs e)
        {
            ComputerTwo computerHard = new ComputerTwo(numberOfCards/2);
            players.Add(computerHard);
            computerHard.diff = "svår";
            computerHard.name = playerNamesVec[players.Count - 1];
            computerHard.DidFindMatchingCards += this.ComputerDidFindMatch;
            computerHard.DidNotFindMatchingCards += this.ComputerDidNotFindMatch;
            UpdateGUI();
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
               
            if(IsFirstPlayerAI())
            {
                if (players[playersTurn] is ComputerTwo)
                {                    
                    timerComputerTick.Enabled = true;
                    //((ComputerTwo)players[playersTurn]).Play();
                }
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
            ResetGame();
        }

        private void timerComputerTick_Tick(object sender, EventArgs e)
        {
            if (players[playersTurn] is ComputerTwo && !DidGameEnd())
            {
                ((ComputerTwo)players[playersTurn]).Play();
            }

            timerComputerTick.Enabled = false;
        }

        private bool DidGameEnd()
        {
            var usedCards = board.cardList.FindAll(x => !x.Playable);

            return usedCards.Count == board.cardList.Count;
        }

      
    }
}



