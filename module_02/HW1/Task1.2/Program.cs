using System;

namespace Task1._2
{
    class Program
    {
        public static int[,] Form(int n)
        {
            int[,] a = new int[n,n];
            int x = 1;
            for(int i=0;i<n;i++)
            {
                int z = x;
                for(int j=0;j<n;j++)
                {
                    if (z == n + 1)
                        z = 1;
                    a[i, j] = z++;
                }
                x++;
            }
            return a;
        }
        public static void OutArr(int[,] a,int n)
        {
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
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
                int[,] a = Form(n);
                OutArr(a, n);
                Console.WriteLine("нажмите Esc, чтобы завершить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
