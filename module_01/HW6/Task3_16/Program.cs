using System;

namespace Task3_16
{
    class Program
    {
        public static int Maxind(int[]a)
        {
            int z = int.MinValue;
            int z1 = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] >= z)
                {
                    z = a[i];
                    z1 = i;
                }
            }
            return z1;
        }
        public static int Minind(int[] a)
        {
            int z = int.MaxValue;
            int z1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= z)
                {
                    z = a[i];
                    z1 = i;
                }
            }
            return z1;
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
                int[] a = new int[n];
                Random r = new Random();
                for(int i=0;i<n;i++)
                {
                    a[i] = r.Next(1, 15);
                }
                OutArr(a);
                Console.WriteLine(Minind(a));
                Console.WriteLine(Minind(a) + Maxind(a));
                Console.WriteLine("Для выхожа нажмите esc, игначе - любой символ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
