﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCodeSamples
{
    class Human : Player
    {
        public Human(string _name)
        {
            name = _name;
        }

        public override bool IsComputer()
        {
            return false;
        }

        public override Card ClickARandomCard(int _numberOfCards, List<Card> _cardlist)
        {
            //does not need to be used
            return null;
        }

        public override void HandleComputerMemory(Card card)
        {
            //does not need to be used
        }
    }
}
