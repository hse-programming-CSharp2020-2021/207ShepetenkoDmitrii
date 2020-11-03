
using Microsoft.VisualBasic;
using System;

namespace Task1
{
    class Func
    {
        double min { get; set; }
        double max { get; set; }
        public Func(double a,double b)
        {
            min = a;
            max = b;
        }
        public double this[double index]
        {
            get
            {
                if ((index < min) | (index > max))
                    return 0;
                else
                    return Math.Sin(index);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Func a = new Func(0, Math.PI);
            for (double i = 0; i < Math.PI; i += Math.PI / 6)
                Console.WriteLine($"{a[i]:f2}");
        }
    }
}
