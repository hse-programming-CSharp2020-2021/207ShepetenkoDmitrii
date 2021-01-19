using System;

namespace Task2
{
    class Program
    {
        delegate int Cast(double a);
        static void Main(string[] args)
        {
            Cast c1 = delegate (double a)
              {
                  return Math.Floor(a) % 2 == 0 ? (int)Math.Floor(a) : (int)Math.Floor(a) + 1;
              };
            Cast c2 = delegate (double a)
            {
                return (int)Math.Log10(a) + 1;
            };
            Console.WriteLine(c1(15.7));
            Console.WriteLine(c2(124255.535));
            Cast c3= delegate (double a)
            {
                Console.WriteLine(Math.Floor(a) % 2 == 0 ? (int)Math.Floor(a) : (int)Math.Floor(a) + 1);
                return Math.Floor(a) % 2 == 0 ? (int)Math.Floor(a) : (int)Math.Floor(a) + 1;
            };
            c3+= delegate (double a)
            {
                return (int)Math.Log10(a) + 1;
            };
            Console.WriteLine(c3(17.5));
            Cast c4= a=> Math.Floor(a) % 2 == 0 ? (int)Math.Floor(a) : (int)Math.Floor(a) + 1;
            Console.WriteLine(c4(15.7));
            Cast c5 = a => (int)Math.Log10(a) + 1;
            Console.WriteLine(c5(746735));
        }
    }
}
