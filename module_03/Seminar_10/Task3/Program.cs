using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            using (StreamWriter se = new StreamWriter("input.txt"))
            {
                for(int i=0;i<100; i++)
                {
                    se.WriteLine(rnd.Next(1000));
                }
            }

            using(StreamReader sr = new StreamReader("input.txt"))
            {
                Console.SetIn(sr);
                int sum=0;
                for(int i = 0; i < 100; i++)
                {
                    sum += int.Parse(Console.ReadLine());
                }
                Console.WriteLine(sum/100);
                Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            }
        }
    }
}
