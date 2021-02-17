using System;

namespace Task1
{
    interface ICalculation
    {
        public double Perform(double i);
    }

    class Add : ICalculation
    {
        double k;
        public Add(double i)
        {
            k = i;
        }
        public double Perform(double i)
        {
            return i + k;
        }
    }

    class Multiply : ICalculation
    {
        double k;
        public Multiply(double i)
        {
            k = i;
        }

        public double Perform(double i)
        {
            return i * k;
        }
    }

    class Program
    {
        static double Calculate(double i, ICalculation a, ICalculation b)
        {                        
            return b.Perform(a.Perform(i)); ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(1,new Add(2), new Multiply(4)));
        }
    }
}
