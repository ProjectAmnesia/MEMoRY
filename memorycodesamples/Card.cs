using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MemoryCodeSamples
{
    public class Card : System.Windows.Forms.Button
    {
        public delegate void cardEvent(object sender, EventArgs e);
        private int _id;
        public Image back, front;
        private bool _flipped;
        private bool _playable = true;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public bool Playable
        {
            get { return _playable; }
            set { _playable = value; }
        }
        public bool Flipped
        {
            get { return _flipped; }
            set
            {
                _flipped = value;
                if (_flipped)
                    this.Image = front;
                else
                    this.Image = back;
            }
        }

        public Card(int posX, int posY, int width, int height)
        {
            Location = new System.Drawing.Point(posX, posY);
            Size = new System.Drawing.Size(width, height);
            back = Properties.Resources.skalet;
            BackColor = System.Drawing.Color.White;
            
        }

        public bool Match(Card card)
        {
            if (card == null)
                return false;
            else if (this.Id == card.Id && !this.Equals(card))
            {
                this.Playable = false;
                this.Enabled = false;
                card.Playable = false;
                card.Enabled = false;
                return true;
            }            
            return false;
        }
    }
}
