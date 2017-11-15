using System;
using System.Collections.Generic;
using System.Text;

namespace ClockDisplay
{
    class NumberDisplay: IUpdateAble
    {
        private int modules;
        private int state;

        private IUpdateAble nextNumberDisplay;

        public NumberDisplay(int modules, IUpdateAble nextNumberDisplay )
        {
            this.modules = modules;

            this.nextNumberDisplay = nextNumberDisplay;
        }

        private bool IsRondjeVol()
        {
            return this.state % this.modules == 0;
        }

        public void Update()
        {
            this.state += 1;

            if( IsRondjeVol() )
            {
                this.nextNumberDisplay.Update();
            }
        }

        public override string ToString()
        {
            int numberToShow = this.state % modules;

            return $"{numberToShow:00}";
        }
    }
}
