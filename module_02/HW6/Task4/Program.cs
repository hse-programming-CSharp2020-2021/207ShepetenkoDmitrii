using System;
using static MyLib.Rename;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticTrinomial q1 =new  QuadraticTrinomial(2, 3, 7);
            QuadraticTrinomial q2 = new QuadraticTrinomial(1, -5, 6);
            int[] x = new int[7] { 1, -3, 3, 2, 7, 100, 0 };
            foreach(int i in x)
            {
                try
                {
                    Console.WriteLine(q1.Division(q2, i));
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
