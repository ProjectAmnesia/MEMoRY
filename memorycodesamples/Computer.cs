using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCodeSamples
{
    class Computer : Player
    {
        public Computer(int numberOfAIs)
        {
            name = "AI nr " + numberOfAIs;
        }
    }
}
