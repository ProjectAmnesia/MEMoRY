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
            btnPlay.Visible = false;
            picBoxTheme.Visible = true;
            rb16cards.Visible = false;
            rb24cards.Visible = false;
            rb36cards.Visible = false;
            rbUsersChoice.Visible = false;
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
                int numberOfCards = 0;
                if(IsNumber(tbNumberOfCards.Text))
                {
                    numberOfCards = int.Parse(tbNumberOfCards.Text);
                }
                else
                {
                    numberOfCards = 16;
                    MessageBox.Show("Du skrev bokstäver,\n du får istället spela med " + numberOfCards + " kort");
                }
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
            if (rbtnFruit.Checked)
            {
                return 1;
                
            }
            else if (rbtnAnimals.Checked)
            {
                return 2;
                
            }
            else
                return 3;
        }
        private void rbUsersChoice_CheckedChanged(object sender, EventArgs e)
        {
            picBoxCardAmountFree.Visible = true;
            tbNumberOfCards.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void rbtnFruit_CheckedChanged(object sender, EventArgs e)
        {
            picBoxTheme.Visible = false;
            picBoxCardAmount.Visible = true;
            btnPlay.Visible = true;
            rbtnFruit.Visible = false;
            rbtnAnimals.Visible = false;
            rbtnCartoon.Visible = false;
            rb16cards.Visible = true;
            rb24cards.Visible = true;
            rb36cards.Visible = true;
            rbUsersChoice.Visible = true;
        }

        private void rbtnAnimals_CheckedChanged(object sender, EventArgs e)
        {
            picBoxTheme.Visible = false;
            picBoxCardAmount.Visible = true;
            btnPlay.Visible = true;
            rbtnFruit.Visible = false;
            rbtnAnimals.Visible = false;
            rbtnCartoon.Visible = false;
            rb16cards.Visible = true;
            rb24cards.Visible = true;
            rb36cards.Visible = true;
            rbUsersChoice.Visible = true;
        }

        private bool IsNumber(string tbInput)
        {
            try
            {
                int.Parse(tbInput);
            }
            catch
            {

                return false;
            }
            return true;
        }

        private void rbtnCartoon_CheckedChanged(object sender, EventArgs e)
        {
            picBoxTheme.Visible = false;
            picBoxCardAmount.Visible = true;
            btnPlay.Visible = true;
            rbtnFruit.Visible = false;
            rbtnAnimals.Visible = false;
            rbtnCartoon.Visible = false;
            rb16cards.Visible = true;
            rb24cards.Visible = true;
            rb36cards.Visible = true;
            rbUsersChoice.Visible = true;
        }
        private void rb16cards_CheckedChanged(object sender, EventArgs e)
        {
            lblCards.Visible = false;
            lblMax.Visible = false;
            tbNumberOfCards.Visible = false;
        }
        private void rb24cards_CheckedChanged(object sender, EventArgs e)
        {
            lblCards.Visible = false;
            lblMax.Visible = false;
            tbNumberOfCards.Visible = false;
        }
        private void rb36cards_CheckedChanged(object sender, EventArgs e)
        {
            lblCards.Visible = false;
            lblMax.Visible = false;
            tbNumberOfCards.Visible = false;
        }

       

        
    }
}
