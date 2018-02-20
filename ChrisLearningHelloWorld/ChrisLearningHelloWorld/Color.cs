using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisLearningHelloWorld
{
    class Color
    {
        public int red;
        public int green;
        public int blue;
        public int alpha;

        public int getRed()
        {
            return red;
        }
        public void SetRed(int red)
        {
            this.red = red;
        }
        public int getGreen()
        {
            return green;
        }
        public void SetGreen(int green)
        {
            this.green = green;
        }
        public int getBlue()
        {
            return blue;
        }
        public void SetBlue(int blue)
        {
            this.blue = blue;
        }
        public Color(int Red, int green, int blue, int alpha)
        {
            this.red   = Red;
            this.green = green;
            this.blue  = blue;
            this.alpha = alpha;
        }
        public Color(int Red, int green, int blue)
        {
            this.red = Red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }
        public double GetGreyScaleColour()
        {
            return (this.red + this.blue + this.green)/ 3;
        }

    }
}
