using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MemoryCodeSamples
{
    public class Board : Panel
    {
        Pictures pic = new Pictures();       
        public delegate void deckEvent(object sender, EventArgs e);
        public List<Card> cardList = new List<Card>();       
        private int margin = 1;
        private deckEvent cardEvent;
        int width, height;

        public Board(int numberOfCards, deckEvent eventhandler)
        {
            cardEvent = eventhandler;
            Width = 700;
            Height = 700;         
        }

        private void randomizeIdInCardList(int numberOfCards)
        {
            List<int> shuffledIntList = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < (numberOfCards / 2); i++)
            {
                shuffledIntList.Insert(rand.Next(0, shuffledIntList.Count + 1), i);
                shuffledIntList.Insert(rand.Next(0, shuffledIntList.Count + 1), i);
            }
            for (int i = 0; i < numberOfCards; i++)
            {
                cardList[i].Id = shuffledIntList[i];
                cardList[i].front = pic.bilder[cardList[i].Id];
            }
        }
        public void CreateNewGame(int numberOfCards, int theme)
        {            
            this.Controls.Clear();
            cardList.Clear();
            int rows, columns;
            rows = (int)Math.Sqrt(numberOfCards);
            columns = numberOfCards / rows;
            int modulo = numberOfCards % rows;
            if (modulo != 0)
            {
                rows += 1;
            }

            width = this.Width / columns - margin;
            height = this.Height / rows - margin;

            pic.ResizeImage(width, height, theme);
            for (int i = 0; i < rows; i++)
            {
                if (i == rows - 1 && modulo != 0)
                {
                    columns = modulo;
                }
                for (int j = 0; j < columns; j++)
                {
                    Card myCard = new Card(j * width + j * margin, i * height + i * margin, width, height);
                    myCard.Flipped = false;
                    myCard.Click += new System.EventHandler(cardEvent);
                    this.Controls.Add(myCard);
                    cardList.Add(myCard);
                }
            }
            randomizeIdInCardList(numberOfCards);
        }
    }
}
