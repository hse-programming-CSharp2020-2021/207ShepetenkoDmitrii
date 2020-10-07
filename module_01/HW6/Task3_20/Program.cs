using System;
using System.Linq;

namespace Task3_20
{
    class Program
    {
        public static void ArrayItemDouble(ref int[]a,int x)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==x)
                {
                    Array.Resize(ref a, a.Length + 1);
                    for(int j=a.Length-1;j>i;j--)
                    {
                        a[j] = a[j - 1];
                    }
                    a[i+1] = x;
                    i += 1;
                }
            }
        }
        public static void OutArr(int[] a)
        {
            foreach (double i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            do
            {
                int n;
                do
                {
                    Console.WriteLine("Введите n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1));
                int x;
                do
                {
                    Console.WriteLine("Введите x");
                } while (!int.TryParse(Console.ReadLine(), out x) | (x < 10));
                int[] a = new int[n];
                Random r = new Random();
                for(int i=0;i<n;i++)
                {
                    a[i] = r.Next(10, 18);
                }
                OutArr(a);
                ArrayItemDouble(ref a,x);
                OutArr(a);
                Console.WriteLine("Для выхода нажмите Esc, мначе - любую другую кнопку.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
