using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MemoryCodeSamples
{
    class Computer : Player
    {
        //List<Card> computerMemory = new List<Card>();
        //public List<Card> allCardsOnBoard = new List<Card>();
        //public Card firstCard, secondCard;
        //int difficulty;

        //public Computer(int _difficulty)
        //{
        //    difficulty = _difficulty;
        //}
        
        //public void ComputerTurn()
        //{
        //    while (true)
        //    {
        //        List<Card> tempMemoryList = FindMatchInMemory();
        //        //Find match in memory
        //        if (tempMemoryList.Count == 2)
        //        {
        //            //Found two cards in memory
        //            foreach (Card c in tempMemoryList)
        //            {
        //                //Flip
        //                c.Flipped = true;
        //                c.Refresh();
        //                Thread.Sleep(500);
        //                c.Disable();
        //                //Remove from computer memory
        //                RemoveCardFromComputerMemory(c);
        //            }
        //        }

        //        else
        //        {
        //            //if no match in memory, pick card from card list
        //            firstCard = PickFirstCard();
        //            //Flip
        //            firstCard.Flipped = true;
        //            firstCard.Refresh();
        //            Thread.Sleep(500);
        //            //Find match in memory
        //            Card matchingCard = FindMatchForFirstCard(firstCard);
        //            if (matchingCard != null)
        //            {
        //                //Flip
        //                matchingCard.Flipped = true;
        //                matchingCard.Refresh();
        //                Thread.Sleep(500);
        //                //Remove card from memory
        //                matchingCard.Disable();
        //                firstCard.Disable();
        //                RemoveCardFromComputerMemory(matchingCard);
        //                RemoveCardFromComputerMemory(firstCard);
        //            }
        //            else
        //            {
        //                // if no match in memory, pick second card
        //                secondCard = PickSecondCard(firstCard);
        //                secondCard.Flipped = true;
        //                secondCard.Refresh();
        //                Thread.Sleep(500);
        //                //Check if match
        //                if (firstCard.Match(secondCard))
        //                {
        //                    //flip
        //                    this.points++;
        //                    firstCard.Disable();
        //                    secondCard.Disable();
        //                    RemoveCardFromComputerMemory(firstCard);
        //                    RemoveCardFromComputerMemory(secondCard);
        //                }
        //                //if no match, add to memory and push out cards last in memory
        //                else
        //                {
        //                    Thread.Sleep(500);
        //                    firstCard.Flipped = false;
        //                    secondCard.Flipped = false;
        //                    HandleComputerMemory(firstCard);
        //                    HandleComputerMemory(secondCard);
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}

        //private List<Card> FindMatchInMemory()
        //{
        //    List<Card> tempMatchList = new List<Card>();
        //    foreach(Card card in computerMemory)
        //    {
        //        if (card.Playable == true)
        //        {
        //            var match = computerMemory.Find(c => c.Match(card));
        //            if (match != null)
        //            {
        //                tempMatchList.Add(match);
        //                tempMatchList.Add(card);
        //                break;
        //            }
        //        }
        //    }
        //    return tempMatchList;
        //}

        //private void RemoveCardFromComputerMemory(Card card)
        //{
        //    computerMemory.Remove(card);
        //}

        //private Card PickFirstCard()
        //{
        //    Random rand = new Random();
        //    while(true)
        //    {
        //        int computerSelection = rand.Next(0, allCardsOnBoard.Count);
        //        Card card = allCardsOnBoard[computerSelection];
        //        if (computerMemory.Count != 0)
        //        {
        //            foreach (Card c in computerMemory)
        //            {
        //                if (c != card && card.Playable == true)
        //                {
        //                    return card;
        //                }
        //            }
        //        }
        //        if(card.Playable)
        //        {
        //            return card;
        //        }
        //    }
        //}

        //private Card PickSecondCard(Card firstCard)
        //{
        //    Random rand = new Random();

        //    while(true)
        //    {
        //        int computerSelection = rand.Next(0, allCardsOnBoard.Count);
        //        Card card = allCardsOnBoard[computerSelection];
        //        if (computerMemory.Count != 0 || card.Equals(firstCard))
        //        {
        //            foreach (Card c in computerMemory)
        //            {
        //                if (c != card && card.Playable == true)
        //                {
        //                    return card;
        //                }
        //            }
        //        }
        //        else if(card.Playable)
        //        {
        //            return card;
        //        }
        //    } 
        //}

        //private Card FindMatchForFirstCard(Card firstCard)
        //{
        //    foreach(Card c in computerMemory)
        //    {
        //        if(firstCard.Match(c))
        //        {
        //            return c;
        //        }
        //    }
        //    return null;
        //}

        //public void HandleComputerMemory(Card card)
        //{
        //    computerMemory.Add(card);
        //    if(computerMemory.Count > difficulty)
        //    {
        //        computerMemory.RemoveAt(difficulty);
        //    }
        //}

        //public void ResetMemory()
        //{
        //    computerMemory.Clear();
        //}
    }
}
