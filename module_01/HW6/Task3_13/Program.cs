using System;

namespace Task3_13
{
    class Program
    {
        public static void OutArr(int[] a)
        {
            foreach (double i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void OutArr1(int[] a,int k)
        {
            for(int i=k-1;i<a.Length;i+=k)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            do
            {
                int n,k;
                do
                {
                    Console.WriteLine("Введите n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1));
                int[] a = new int[n];
                do
                {
                    Console.WriteLine("Введите k");
                } while (!int.TryParse(Console.ReadLine(), out k) | (k < 1)|(k>n));
                Random r= new Random();
                for(int i=0;i<n;i++)
                {
                    a[i] = r.Next(1, 150);
                }
                OutArr(a);
                OutArr1(a, k);
                Console.WriteLine("Для выхожа нажмите esc, игначе - любой символ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
