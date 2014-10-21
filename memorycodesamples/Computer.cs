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
        List<Card> computerMemory = new List<Card>();
        public List<Card> cardList = new List<Card>();
        int difficulty = 6; //temporary

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
            //victor: text
            foreach (Card c in cardList)
            {
                if (c.Playable == true)
                {
                    return c;
                }
            }
            return null; //this code should never run
        }

        public override void HandleComputerMemory(Card card)
        {
            computerMemory.Add(card);
            if (computerMemory.Count > difficulty)
            {
                computerMemory.RemoveAt(difficulty);
            }
        }

        private List<Card> FindMatchInMemory()
        {
            List<Card> tempMatchList = new List<Card>();
            foreach (Card card in computerMemory)
            {
                if (card.Playable == true)
                {
                    var match = computerMemory.Find(c => c.Match(card));
                    if (match != null)
                    {
                        tempMatchList.Add(match);
                        tempMatchList.Add(card);
                        break;
                    }
                }
            }
            return tempMatchList;
        }

        private Card SecondMatch (Card _card)
        {
            //returns second matching card
            Card card = _card;
            return card;
        }

    }
}
