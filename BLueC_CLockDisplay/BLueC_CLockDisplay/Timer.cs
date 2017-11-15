using System;
using System.Collections.Generic;
using System.Text;

namespace ClockDisplay
{
    class Timer
    {
        public IUpdateAble nextDisplay;
        public IUpdateAble clock;
        public int timeoutInMillisecons;

        public Timer(IUpdateAble nextDisplay, IUpdateAble clock)
        {
            // we willen elke seconde een update
            timeoutInMillisecons = 1000;
            this.nextDisplay = nextDisplay;
            this.clock = clock;
        }

        public void Start()
        {
            while(true)
            {
                System.Threading.Thread.Sleep(this.timeoutInMillisecons);

                nextDisplay.Update();

                // bij iedere update de clock bijwerken
                clock.Update();
            }
        }
    }
}
