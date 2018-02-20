using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisLearningHelloWorld
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public int Red   { get => red;   set => red   = value; }
        public int Green { get => green; set => green = value; }
        public int Blue  { get => blue;  set => blue  = value; }
        public int Alpha { get => alpha; set => alpha = value; }

        public Color(int Red, int green, int blue, int alpha)
        {
            this.Red   = Red;
            this.Green = green;
            this.Blue  = blue;
            this.Alpha = alpha;
        }
        public Color(int Red, int green, int blue)
        {
            this.Red = Red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = 255;
        }
        public double GetGreyScaleColour()
        {
            return (this.Red + this.Blue + this.Green)/ 3;
        }

    }
}
