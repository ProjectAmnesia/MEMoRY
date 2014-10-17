using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCodeSamples
{
    class Computer: Player
    {
        int lastSelection;
        bool useNextCard = false;
        Random rand = new Random();
        public List<Card> cardList = new List<Card>();

        public Computer(string _name)
        {
            name = _name;
        }

        public override bool IsComputer()
        {
            return true;
        }

        public override Card ClickARandomCard(int _numberOfCards, List<Card> _cardlist)
        {
            int numberOfCards = _numberOfCards;
            cardList = _cardlist;
            useNextCard = false;
            foreach (Card c in cardList)
            { 
                if (c.Playable == false)
                {
                    numberOfCards--;
                }
            }
            int computerSelection = rand.Next(0, numberOfCards);
            int i = 0;
            foreach (Card c in cardList)
            {
                if (c.Playable)
                {
                    if (i == computerSelection)
                    {
                        if (useNextCard == true)
                        {
                            return c;
                        }
                        else if (lastSelection == computerSelection)
                        {
                            useNextCard = true;
                        }
                        else
                        {
                            lastSelection = computerSelection;
                            return c;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            //om man har kommit hit finns antagligen få spelbara kort
            foreach (Card c in cardList)
            {
                if (c.Playable == true)
                {
                    return c;
                }
            }
            return null; //man borde aldrig komma hit
        }

    }
}
