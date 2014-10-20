using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCodeSamples
{
    abstract class Player
    {
        public string name;
        public int points;

        public abstract bool IsComputer();
        public abstract Card ClickARandomCard(int _numberOfCards, List<Card> _cardlist);
    }
}
