using System;
using Structures;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleS[] circles = new CircleS[10];
            Random r = new Random();
            for( int i = 0; i < circles.Length; i++)
            {
                circles[i] = new CircleS(r.Next(15) + r.NextDouble(), r.Next(15) + r.NextDouble(), r.Next(15) + r.NextDouble());
                Console.WriteLine(circles[i]);
            }
            Console.WriteLine();
            Array.Sort(circles);
            foreach (CircleS i in circles)
                Console.WriteLine(i);
        }
    }
}
