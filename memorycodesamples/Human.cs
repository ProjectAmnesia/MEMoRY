﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCodeSamples
{
    class Human : Player
    {
        public Human(int numberOfPlayers)
        {
            name = "Spelare nr " + numberOfPlayers;
        }
    }
}
