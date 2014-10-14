using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCodeSamples
{
    public class Timer
    {
        DateTime timeNow = DateTime.Now;

        public void TimerDelay(Board board)
        {

            for (int i = 0; i < board.cardList.Count; i++)
            {


                // will add 5 sec on the Time5back and reloop it until time has catch up
                while (timeNow.AddMinutes(1) > DateTime.Now);
                { MessageBox.Show("test "+timeNow+" TimerCheck"); }
            }

        }
    }
}
