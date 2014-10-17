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
    public partial class GameSettings : Form
    {
        Pictures pic = new Pictures();  
        public GameSettings()
        {
            InitializeComponent();
            grBTheme.Visible = true;
            btnPlay.Visible = false;
        }

        public int EnteredNumberOfCards()
        {
            if(rb16cards.Checked)
            {
                return 16;
            }
            else if (rb24cards.Checked)
            {
                return 24;
            }
            else if(rb36cards.Checked)
            {
                return 36;
            }
            else
            {
                int numberOfCards = int.Parse(tbNumberOfCards.Text);
                if (numberOfCards % 2 != 0)
                {
                    numberOfCards += 1;
                    MessageBox.Show("Du angav ett ojämnt antal kort,\n du får istället spela med " + numberOfCards + " kort");
                }
                if (numberOfCards > 120)
                {
                    numberOfCards = 120;
                    MessageBox.Show("Det går att spela med max 120 kort,\nvarsågod!");
                }
                if (numberOfCards < 4)
                {
                    numberOfCards = 4;
                    MessageBox.Show("Det är ingen utmaning med bara två kort\ntesta 4!");
                }
                return numberOfCards;
            }
        }
        public int ChooseTheme()
        {
            if(rbtnFruit.Checked)
            {
                return 1;
                
            }
            else
            {
                return 2;
                
            }

           
        }
        private void rbUsersChoice_CheckedChanged(object sender, EventArgs e)
        {
            lblCards.Visible = true;
            lblMax.Visible = true;
            tbNumberOfCards.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameSettings_Load(object sender, EventArgs e)
        {

        }

        private void rbtnFruit_CheckedChanged(object sender, EventArgs e)
        {
            grBTheme.Visible = false;
            grBNumberOfCards.Visible = true;
            btnPlay.Visible = true;
        }

        private void rbtnAnimals_CheckedChanged(object sender, EventArgs e)
        {
            grBTheme.Visible = false;
            grBNumberOfCards.Visible = true;
            btnPlay.Visible = true;
        }

        

        

        
    }
}
