using System;

namespace Task1
{
    class Program
    {
        delegate double P(int i);
        delegate double S();
        static void Main(string[] args)
        {
            double x = 2;
            P p = i =>
              {
                  double p = 1;
                  for (int j = 1; j <= 5; j++)
                      p *= i * x / j;
                  return p;
              };
            S s = () =>
              {
                  double sum = 0;
                  for (int i = 1; i < 5; i++)
                  {
                      sum += p(i);
                  }
                  return sum;
              };
            Console.Write(s());
        }
    }
}
