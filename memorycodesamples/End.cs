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
    public partial class End : Form
    {

        public string winner;

        public string Winner
        {
            get { return winner; }
            set { winner = value; }
        }
        public End()
        {
            InitializeComponent();

            lblWinner.Text = winner;
        }
        public void ShowWinner()
        {
            lblWinner.Text = winner;
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



       
    }
}
