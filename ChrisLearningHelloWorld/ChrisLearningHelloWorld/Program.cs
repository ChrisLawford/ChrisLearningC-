using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisLearningHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writing my first line of C# whilst actually learning the language
            Console.WriteLine("Hello World!");

            // Declaring my first variable and assigning it a value.
            int score = 0;

            // When you access a variable you are getting a copy
            Console.WriteLine(score);

            // using string interpolation
            Console.WriteLine($"The score is {score}");

            // Conditional operator
            Console.WriteLine((score > 70) ? "You passed" : "You failed");

            // Create array
            int[] classes = new int[10];
            
            for (int i=0; i<10; i++)
            {
                classes[i] = i * 2;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(classes[i]);
            }
            for (int i = 0; i < classes.Length/2; i++)
            {
                int temp = classes[i];
                classes[i] = classes[classes.Length - (i+1)];
                classes[classes.Length - (i+1)] = temp;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(classes[i]);
            }
            ///
            /// Ready to start the ball class
            /// 

            Ball Ball1 = new Ball(10, new Color(1,2,3));
            Ball Ball2 = new Ball(5, new Color(1, 2, 3));
            Ball Ball3 = new Ball(2, new Color(1, 2, 3));

            Ball1.Throw_Ball();

            Console.WriteLine("Ball 1 :" + Ball1.Ball_Throw_count() + ' ' + Ball1.GetGreyScaleColour);
            Ball1.Throw_Ball();
            Console.WriteLine("Ball 1 :" + Ball1.Ball_Throw_count());
            Ball1.Pop_Ball();
            Console.WriteLine("Ball 1 :" + Ball1.Ball_Throw_count());
            Ball1.Throw_Ball();
            Console.WriteLine("Ball 1 :" + Ball1.Ball_Throw_count());

            Console.ReadKey();
        }
    }
}
