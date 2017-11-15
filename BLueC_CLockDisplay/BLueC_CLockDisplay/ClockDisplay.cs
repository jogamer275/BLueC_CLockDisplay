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
        // hours
        // days

        public ClockDisplay()
        {
            // days

            // hours

            // minutes
            this.minutesDisplay = new NumberDisplay(3, this);

            // seconds
            this.secondsDisplay = new NumberDisplay(3, minutesDisplay);


            // timer geeft de eerste display in de keten een schop
            timer = new Timer(secondsDisplay, this);
        }

        public void Start()
        {
            this.timer.Start();
        }

        public void Update()
        {
            string time = $"Het is: ?dagen ?uren?:{minutesDisplay}:{secondsDisplay}";

            Console.Clear();
            Console.Write(time);
        }
    }
}
