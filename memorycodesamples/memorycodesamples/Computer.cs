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
            int computerSelection = rand.Next(0, numberOfCards);
            int i = 0;
            foreach (Card c in cardList)
            {
                if (i == computerSelection)
                {
                    //om kortet inte är spelbart eller om det är samma kort den valde nyss går datorn
                    //igenom metoden igen, tills den får ett godtagbart val. 
                    if (c.Playable == false)
                    {
                        Card c2 = ClickARandomCard(numberOfCards, cardList);
                        lastSelection = computerSelection;
                        return c2;
                    }
                    else if (lastSelection == computerSelection)
                    {
                        Card c2 = ClickARandomCard(numberOfCards, cardList);
                        lastSelection = computerSelection;
                        return c2;
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
            return null; //man borde aldrig komma hit
        }

    }
}
