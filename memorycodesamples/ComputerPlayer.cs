using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCodeSamples
{
    class Computer : Player
    {
        List<Card> computerMemory = new List<Card>();
        public List<Card> allCardsOnBoard = new List<Card>();

        int difficulty;
        public Computer(int _difficulty)
        {
            difficulty = _difficulty;
        }
        
        public void ComputerTurn()
        {
            List<Card> tempMemoryList = FindMatchInMemory();
            //Find match in memory
            if(tempMemoryList.Count == 2)
            {
                //Found two cards in memory
                foreach(Card c in tempMemoryList)
                {
                    //Flip

                    //Remove from computer memory
                    RemoveCardFromComputerMemory(c);
                }
            }
            
            else
            {
                //if no match in memory, pick card from card list
                Card firstCard = PickFirstCard();
                //Find match in memory

                // if no match in memory, pick second card

                //Check if match

                //if no match, add to memory and push out cards last in memory
            }
        }

        private List<Card> FindMatchInMemory()
        {
            List<Card> tempMatchList = new List<Card>();
            foreach(Card card in computerMemory)
            {
                var match = computerMemory.Find(c => c.Match(card));
                if(match != null)
                {
                    tempMatchList.Add(match);
                    tempMatchList.Add(card);
                }
            }
            return tempMatchList;
        }

        private void RemoveCardFromComputerMemory(Card card)
        {
            computerMemory.Remove(card);
        }

        private Card PickFirstCard()
        {
            Random rand = new Random();
            while(true)
            {
                int computerSelection = rand.Next(0, allCardsOnBoard.Count -1);
                Card card = allCardsOnBoard[computerSelection];
                foreach(Card c in computerMemory)
                {
                    if(c != card)
                    {
                        return card; 
                    }
                }
            }
        }

        private 
    }
}
