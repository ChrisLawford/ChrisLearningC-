using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisLearningHelloWorld
{
    class Ball
    {
        public int Ball_thrown_count;
        public int Ball_size;
        public Color Ball_colour;

        public Ball(int size, Color Ball_colour)
        {
            this.Ball_size = size;
            this.Ball_colour = Ball_colour;
            this.Ball_thrown_count = 0;
        }

        public void Pop_Ball()
        {
            this.Ball_size = 0;
        }
        public void Throw_Ball()
        {
            if (this.Ball_size > 0)
            {
                this.Ball_thrown_count++;
            }
        }
        public int Ball_Throw_count()
        {
            return this.Ball_thrown_count;
        }

    }
}
