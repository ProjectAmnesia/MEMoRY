using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace MemoryCodeSamples
{
    public enum Level
    {
        Easy,
        Medium,
        Hard
    }

    class Computer : Player
    {
        // Delegates & Events:

        public delegate void EventComputerDidFinish(Card cardOne, Card cardTwo, Computer computer);
        public event EventComputerDidFinish DidFindMatchingCards;
        public event EventComputerDidFinish DidNotFindMatchingCards;

        // Fields:

        private List<Card> memory = new List<Card>();
        private List<Card> cardsOnBoard = new List<Card>();
        private Random random = new Random();
        private Level level;

        // Properties:

        private List<Card> AllPlayableCards
        {
            get
            {
                return cardsOnBoard.FindAll(c => c.Playable == true);
            }
        }

        private int Difficulty {
            get
            {
                float percent = 0.0f;
                if (level == Level.Easy)
                {
                    percent = 20.0f;
                }
                else if(level == Level.Medium)
                {
                    percent = 40.0f;
                }
                else
                {
                    percent = 50.0f;
                }
                float x = cardsOnBoard.Count * ((float)percent / 100.0f);
                return (int)x;
            }
        }

        // Constructors:

        public Computer(Level level)
        {            
            this.level = level;
        }

        // Methods:

        public void CardsOnBoard(List<Card> cards)
        {
            cardsOnBoard = cards;
        }

        public void Play()
        {
            var tempMatch = FindMatchInMemory();
            if (tempMatch.Count == 2)
            {
                // Remove matched cards from memory
                RemoveCardFromComputerMemory(tempMatch[0]);
                RemoveCardFromComputerMemory(tempMatch[1]);

                // Invoke event
                DidFindMatchingCards.Invoke(tempMatch[0], tempMatch[1], this);
            }
            else
            {
                // Pick a card that does not exist in memory
                Card firstCard = PickFirstCard();
                Card match = FindMatchInMemoryForFirstCard(firstCard);
                if (match != null)
                {
                    // Remove matched cards from memory
                    RemoveCardFromComputerMemory(match);

                    // Invoke event
                    DidFindMatchingCards.Invoke(firstCard, match, this);
                }
                else
                {
                    // Pick second card
                    Card secondCard = PickSecondCard(firstCard);
                    if (secondCard.Match(firstCard))
                    {
                        // Invoke event
                        DidFindMatchingCards.Invoke(firstCard, secondCard, this);
                    }
                    else
                    {
                        // Did NOT find two cards that matched!
                        // Add cards to memory
                        //AddToComputerMemory(firstCard);
                        //AddToComputerMemory(secondCard);

                        // Invoke event
                        DidNotFindMatchingCards.Invoke(firstCard, secondCard, this);
                    }
                }
            }
        }

        private List<Card> FindMatchInMemory()
        {
            // Check to see if two cards already match in memory
            List<Card> temp = new List<Card>();
            foreach (Card card in memory)
            {
                var match = memory.Find(c => c.Match(card) && c.Playable == true);
                if (match != null)
                {
                    temp.Add(match);
                    temp.Add(card);
                    break;
                }
            }
            return temp;
        }

        private Card PickFirstCard()
        {
            while (true)
            {
                var temp = cardsOnBoard;
                int computerSelection = random.Next(0, AllPlayableCards.Count);
                Card card = AllPlayableCards[computerSelection];

                
                if (memory.Count < AllPlayableCards.Count)
                {
                    if (!memory.Contains(card))
                    {
                        return card;
                    }
                }
                else
                {
                    return card;
                }
                
            }
            
        }

        private Card FindMatchInMemoryForFirstCard(Card firstCard)
        {
            foreach (Card c in memory)
            {
                if (firstCard.Match(c))
                {
                    return c;
                }
            }
            return null;
        }

        private Card PickSecondCard(Card firstCard)
        {
            // Check to see if there is a card in memory that match first card
            foreach (Card card in memory)
            {
                if (card.Match(firstCard))
                {
                    return card;
                }
            }

            // Otherwise pick a random card
            while (true)
            {
                int computerSelection = random.Next(0, AllPlayableCards.Count);
                Card randomCard = AllPlayableCards[computerSelection];
                if (!randomCard.Equals(firstCard))
                {
                    if (memory.Count < 1)
                    {
                        return randomCard;
                    }
                    else
                    {
                        foreach (Card c in memory)
                        {
                            if (!randomCard.Equals(c))
                            {
                                return randomCard;
                            }
                        }
                    }
                }
            }
        }

        public void AddToComputerMemory(Card card)
        {
            memory.Add(card);
            if (memory.Count > Difficulty)
            {
                memory.RemoveAt(Difficulty);
            }
        }

        private void RemoveCardFromComputerMemory(Card card)
        {
            memory.Remove(card);
        }

        public void ResetMemory()
        {
            memory.Clear();
        }

    }
    
}
