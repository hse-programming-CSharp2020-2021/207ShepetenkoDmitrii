using System;

namespace Task2
{
    interface ISequence
    {
        public double GetElement(int n);
    }

    class ArithmeticProgression : ISequence
    {
        double first;
        double d;
        public ArithmeticProgression(double s, double d)
        {
            first = s;
            this.d = d;
        }
        public double GetElement(int n)
        {
            return first+ d * (n - 1);
        }
    }

    class GeometricalProgression : ISequence
    {
        double first;
        double d;
        public GeometricalProgression(double s, double d)
        {
            first = s;
            this.d = d;
        }
        public double GetElement(int n)
        {
            return first * Math.Pow(d, n - 1);
        }
    }

    class Program
    {
        static double Sum(ISequence a, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += a.GetElement(i);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new ArithmeticProgression(1, 5), 4));
        }
    }
}
