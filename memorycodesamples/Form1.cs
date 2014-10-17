using System;
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
        int numberOfCards = 16;
        Board board;
        int playersTurn;
        bool gameStarted = false;
        Card lastFlipped;
        int flippedCards;
        int usedCards = 0;
        int computersTurn = 0;
        List<Player> players = new List<Player>();

        public Form1()
        {
            InitializeComponent();
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
            GameSettings game = new GameSettings();
            DialogResult dialog = game.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                numberOfCards = game.EnteredNumberOfCards();
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

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
            FlipAllCards();
            players.Clear();
            UpdateGUI();
            // groupBox1 är disabled så att den första spelaren alltid måste vara en människa,
            // eftersom spelet startar när man trycker på ett kort
            groupBox1.Enabled = false;
            rbComputer.Checked = false;
            rbHuman.Checked = true;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            FlipAllCards();
            board.CreateNewGame(numberOfCards);
            foreach (var player in players)
            {
                player.points = 0;
            }
            playersTurn = 0;
            UpdateGUI();
        }

        private void card_Click(object sender, EventArgs e)
        {
            if (players.Count < 1)
                return;
            if (players[playersTurn].IsComputer())
            {
                if (computersTurn == 0)
                {
                    return;
                }
                else
                {
                    computersTurn = 0;
                }
            }
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
                    players[playersTurn].points++;
                    playersTurn--;
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
            if (rbHuman.Checked)
            {

                Human human = new Human(tbxPlayerName.Text);
                players.Add(human);
            }
            else
            {
                Computer computer = new Computer(tbxPlayerName.Text);
                players.Add(computer);
            }
            groupBox1.Enabled = true;
            UpdateGUI();
        }

        private void timerFlipBack_Tick(object sender, EventArgs e)
        {
            FlipAllPlayableCards();
            timerFlipBack.Enabled = false;
            //datorns tur startar efter att korten här vänts, så man tydligt ser vilka kort den väljer
            if (players[playersTurn].IsComputer())
            {
                timerHaltComputer.Enabled = true;
            }
            UpdateGUI();            
        }

        private void timerDrawTime_Tick(object sender, EventArgs e)
        {
            FlipAllPlayableCards();
            lastFlipped = null;
            IncrementPlayer();
            timerDrawTime.Enabled = false;
            //se timerFlipBack_Tick
            if (players[playersTurn].IsComputer())
            {
                timerHaltComputer.Enabled = true;
            }      
            UpdateGUI();            
        }

        private void timerHaltComputer_Tick(object sender, EventArgs e)
        {
            //om det finns spelbara kort väljer den två kort och trycker på dem.
            var unplayable = board.cardList.FindAll(x => !x.Playable);
            if (unplayable.Count() != board.cardList.Count())
            {
                object o = players[playersTurn].ClickARandomCard(numberOfCards, board.cardList);
                computersTurn = 1;
                card_Click(o, EventArgs.Empty);
            }
            unplayable = board.cardList.FindAll(x => !x.Playable);
            if (unplayable.Count() != board.cardList.Count())
            {
                object o = players[playersTurn].ClickARandomCard(numberOfCards, board.cardList);
                computersTurn = 1;
                card_Click(o, EventArgs.Empty);
            }
            timerHaltComputer.Enabled = false;
        }

       
    }
}
