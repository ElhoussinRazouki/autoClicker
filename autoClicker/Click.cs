using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoClicker
{
    public class Click
    {
        private int axeX, axeY ;
        private int interval, intervalFrom, intervalTo ;
        private int mouseButtonDown, mouseButtonUp;
        private int nbrOnClick, nbrClicks ;


        public int MOUSEEVENET_LEFTDOWN = 0x0002;
        public int MOUSEEVENET_LEFTUP = 0x0004;
        public int MOUSEEVENTF_MIDDLEDOWN = 0x002;
        public int MOUSEEVENTF_MIDDLEUP = 0x004;
        public int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public int MOUSEEVENTF_RIGHTUP = 0x001;
        

        public int AxeX { get => axeX; set => axeX = value; }
        public int AxeY { get => axeY; set => axeY = value; }
        public int Interval { get => interval; set => interval = value; }
        public int IntervalFrom { get => intervalFrom; set => intervalFrom = value; }
        public int IntervalTo { get => intervalTo; set => intervalTo = value; }
        public int MouseButtonDown { get => mouseButtonDown; set => mouseButtonDown = value; }
        public int MouseButtonUp { get => mouseButtonUp; set => mouseButtonUp = value; }
        public int NbrOnClick { get => nbrOnClick; set => nbrOnClick = value; }
        public int NbrClicks { get => nbrClicks; set => nbrClicks = value; }

        public Click() {
            this.interval = 3;
            this.nbrClicks = 1;
            this.mouseButtonDown = this.MOUSEEVENET_LEFTDOWN;
            this.mouseButtonUp = this.MOUSEEVENET_LEFTUP;

        }

    }
}
