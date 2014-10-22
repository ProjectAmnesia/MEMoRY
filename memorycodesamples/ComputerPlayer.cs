using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MemoryCodeSamples
{
    class ComputerTwo : Player
    {

        // Delegates & Events:

        public delegate void EventComputerDidFinish(Card cardOne, Card cardTwo, ComputerTwo computer);
        public event EventComputerDidFinish DidFindMatchingCards;
        public event EventComputerDidFinish DidNotFindMatchingCards;

        // Fields:

        private List<Card> memory = new List<Card>();
        private List<Card> cardsOnBoard = new List<Card>();
        private Random random = new Random();
        private int _difficulty;

        // Properties:

        public int Difficulty
        {
            get { return _difficulty; }
        }

        private List<Card> AllPlayableCards
        {
            get
            {
                return cardsOnBoard.FindAll(c => c.Playable == true);
            }
        }

        // Constructors:

        public ComputerTwo(int difficulty)
        {
           
            _difficulty = difficulty;
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
                        AddToComputerMemory(firstCard);
                        AddToComputerMemory(secondCard);

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
            int computerSelection = random.Next(0, AllPlayableCards.Count);
            Card card = AllPlayableCards[computerSelection];
            return card;
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
                            if (!randomCard.Equals(c))//varför inte egentligen?
                            {
                                return randomCard;//vad blir det annars?
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

    }

    /**********************************************/
    class Computer : Player
    {
        List<Card> computerMemory = new List<Card>();
        public List<Card> allCardsOnBoard = new List<Card>();
        public Card firstCard, secondCard;
        int difficulty;

        public Computer(int _difficulty)
        {
            difficulty = _difficulty;
        }

        public void ComputerTurn()
        {
            while (true)
            {
                List<Card> tempMemoryList = FindMatchInMemory();
                //Find match in memory
                if (tempMemoryList.Count == 2)
                {
                    //Found two cards in memory
                    foreach (Card c in tempMemoryList)
                    {
                        //Flip
                        c.Flipped = true;
                        c.Refresh();
                        Thread.Sleep(500);
                        c.Disable();
                        //Remove from computer memory
                        RemoveCardFromComputerMemory(c);
                    }
                }

                else
                {
                    //if no match in memory, pick card from card list
                    firstCard = PickFirstCard();
                    //Flip
                    firstCard.Flipped = true;
                    firstCard.Refresh();
                    Thread.Sleep(500);
                    //Find match in memory
                    Card matchingCard = FindMatchForFirstCard(firstCard);
                    if (matchingCard != null)
                    {
                        //Flip
                        matchingCard.Flipped = true;
                        matchingCard.Refresh();
                        Thread.Sleep(500);
                        //Remove card from memory
                        matchingCard.Disable();
                        firstCard.Disable();
                        RemoveCardFromComputerMemory(matchingCard);
                        RemoveCardFromComputerMemory(firstCard);
                    }
                    else
                    {
                        // if no match in memory, pick second card
                        secondCard = PickSecondCard(firstCard);
                        secondCard.Flipped = true;
                        secondCard.Refresh();
                        Thread.Sleep(500);
                        //Check if match
                        if (firstCard.Match(secondCard))
                        {
                            //flip
                            this.points++;
                            firstCard.Disable();
                            secondCard.Disable();
                            RemoveCardFromComputerMemory(firstCard);
                            RemoveCardFromComputerMemory(secondCard);
                        }
                        //if no match, add to memory and push out cards last in memory
                        else
                        {
                            Thread.Sleep(500);
                            firstCard.Flipped = false;
                            secondCard.Flipped = false;
                            HandleComputerMemory(firstCard);
                            HandleComputerMemory(secondCard);
                            break;
                        }
                    }
                }
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

        public void RemoveCardFromComputerMemory(Card card)
        {
            computerMemory.Remove(card);
        }

        private Card PickFirstCard()
        {
            Random rand = new Random();
            while (true)
            {
                int computerSelection = rand.Next(0, allCardsOnBoard.Count);
                Card card = allCardsOnBoard[computerSelection];
                if (computerMemory.Count != 0)
                {
                    foreach (Card c in computerMemory)
                    {
                        if (c != card && card.Playable == true)
                        {
                            return card;
                        }
                    }
                }
                if (card.Playable)
                {
                    return card;
                }
            }
        }

        private Card PickSecondCard(Card firstCard)
        {
            Random rand = new Random();

            while (true)
            {
                int computerSelection = rand.Next(0, allCardsOnBoard.Count);
                Card card = allCardsOnBoard[computerSelection];
                if (computerMemory.Count != 0 || card.Equals(firstCard))
                {
                    foreach (Card c in computerMemory)
                    {
                        if (c != card && card.Playable == true)
                        {
                            return card;
                        }
                    }
                }
                else if (card.Playable)
                {
                    return card;
                }
            }
        }

        private Card FindMatchForFirstCard(Card firstCard)
        {
            foreach (Card c in computerMemory)
            {
                if (firstCard.Match(c))
                {
                    return c;
                }
            }
            return null;
        }

        public void HandleComputerMemory(Card card)
        {
            computerMemory.Add(card);
            if (computerMemory.Count > difficulty)
            {
                computerMemory.RemoveAt(difficulty);
            }
        }

        public void ResetMemory()
        {
            computerMemory.Clear();
        }
    }
}
