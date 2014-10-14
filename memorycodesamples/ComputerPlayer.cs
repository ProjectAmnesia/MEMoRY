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
                Card firstCard = PickCard();
                //Flip
                firstCard.Flipped = true;
                //Find match in memory
                Card matchingCard = FindMatchForFirstCard(firstCard);
                if (matchingCard != null)
                {
                    //Flip
                    matchingCard.Flipped = true;
                    //Remove card from memory
                    RemoveCardFromComputerMemory(matchingCard);
                }
                else
                {
                    // if no match in memory, pick second card
                    Card secondCard = PickCard();
                    secondCard.Flipped = true;
                    //Check if match
                    if(firstCard.Match(secondCard))
                    {
                        //flip
                        this.points++;
                        firstCard.Playable = false;
                        secondCard.Playable = false;
                    }
                    //if no match, add to memory and push out cards last in memory
                    else
                    {
                        HandleComputerMemory(firstCard);
                        HandleComputerMemory(secondCard);
                    }
                }
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

        private Card PickCard()
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

        private Card FindMatchForFirstCard(Card firstCard)
        {
            foreach(Card c in computerMemory)
            {
                if(firstCard.Match(c))
                {
                    return c;
                }
            }
            return null;
        }

        private void HandleComputerMemory(Card card)
        {
            computerMemory.Add(card);
            if(computerMemory.Count > difficulty)
            {
                computerMemory.RemoveAt(difficulty);
            }
        }
    }
}
