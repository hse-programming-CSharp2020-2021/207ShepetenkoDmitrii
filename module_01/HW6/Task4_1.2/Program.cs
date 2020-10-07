using System;

namespace Task4_1._2
{
    class Program
    {
        public static void Fill(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == (n - j - 1))
                        a[i, j] = 0;
                    if (i > (n - j - 1))
                        a[i, j] = 1;
                    if (i < (n - j - 1))
                        a[i, j] = -1;

                }
            }
        }
        public static void OutArr2(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
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
                int[,] a = new int[n, n];
                Fill(a, n);
                OutArr2(a, n);
                Console.WriteLine("для выхода намжмите Esc, иначе - любую другую кнопку.");
            }while(Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
