using System;
using System.Collections.Generic;
using System.Text;

namespace ClockDisplay
{
    class ClockDisplay: IUpdateAble
    {
        public Timer timer;
        public NumberDisplay secondsDisplay;
        public NumberDisplay minutesDisplay;
        public NumberDisplay urenDisplay;
        public NumberDisplay dagenDisplay;
        // hours
        // days

        public ClockDisplay()
        {

            // days
            this.dagenDisplay = new NumberDisplay(365, this);

            // hours
            this.urenDisplay = new NumberDisplay(24, dagenDisplay );


            // minutes
            this.minutesDisplay = new NumberDisplay(60, urenDisplay);

            // seconds
            this.secondsDisplay = new NumberDisplay(60, minutesDisplay);


            // timer geeft de eerste display in de keten een schop
            timer = new Timer(secondsDisplay, this);
        }

        public void Start()
        {
            this.timer.Start();
        }

        public void Update()
        {
            string time = $"Het is: {dagenDisplay}:{urenDisplay}:{minutesDisplay}:{secondsDisplay}";

            Console.Clear();
            Console.Write(time);
        }
    }
}
