using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MemoryCodeSamples
{
    public class Sounds
    {
    

     public void WinnerSound()
        {
            SoundPlayer WinnerSound = new SoundPlayer(Properties.Resources.happy_clapps);
            WinnerSound.Play();
        }

     public void ClockSound()
     {
         SoundPlayer ClockSound = new SoundPlayer(Properties.Resources.clock_ticking);
         ClockSound.Play();
     }

     public void IntroSound()
     {
         SoundPlayer IntroSound = new SoundPlayer(Properties.Resources.pianomoodhappy);
         IntroSound.Play();

     }

     public void PairSound()
     {
         SoundPlayer PairSound = new SoundPlayer(Properties.Resources.Pair_correct);
         PairSound.Play();
     }
    }

}
