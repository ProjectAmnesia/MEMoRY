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
        public GameSettings()
        {
            InitializeComponent();            
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

        private void rbUsersChoice_CheckedChanged(object sender, EventArgs e)
        {
            lblCards.Visible = true;
            lblMax.Visible = true;
            tbNumberOfCards.Visible = true;
        }
    }
}
