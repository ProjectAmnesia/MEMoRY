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
    public partial class StartWithRadioButtons : Form
    {
        
        public string themeChosen; 

        public StartWithRadioButtons()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Du måste välja temat först.");
                 
            }
                
            if (radioButton1.Checked) 
            {

                returnTheme();
                DialogResult = DialogResult.OK;
                
            }// Choose Pictures of tema1
            else if (radioButton2.Checked) 
            {
                returnTheme(); 
                DialogResult = DialogResult.OK;
            }//choose pictures of tema 2 

           

        }
        public string returnTheme()
        {
            if (radioButton1.Checked)
            {
                themeChosen = "themeNumberOne";
                return themeChosen;
            }
            else if (radioButton2.Checked)
            {
                themeChosen = "themeNumberTwo";
                return themeChosen;
            }
            else return "";
                           
        }
    }
}
