using System;

namespace Task4_5
{
    class Program
    {
        public static void OutArr(char[,] a, int n)
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
        public static void Fill1(char[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i > j) & (i < (n - j - 1)))
                        a[i, j] = '+';
                    else
                        a[i, j] = '-';
                }
            }
        }
        public static void Fill2(char[,] a, int n)
         {
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                    if ((i > j) & (i > (n - j - 1)))
                        a[i, j] = '+';
                    else
                        a[i, j] = '-';
                }
             }
         }
        public static void Fill3(char[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (((i > j) & (i > (n - j - 1)))| ((i < j) & (i < (n - j - 1))))
                        a[i, j] = '+';
                    else
                        a[i, j] = '-';
                }
            }
        }
        public static void Fill4(char[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (((i > j) & (i > (n - j - 1))&(j>=n/2)) | ((i < j) & (i < (n - j - 1))&(j<=n/2)))
                        a[i, j] = '+';
                    else
                        a[i, j] = '-';
                }
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
                char[,] a = new char[n, n];
                Fill1(a, n);
                OutArr(a, n);
                Console.WriteLine();
                Fill2(a, n);
                OutArr(a, n);
                Console.WriteLine();
                Fill3(a, n);
                OutArr(a, n);
                Console.WriteLine();
                Fill4(a, n);
                OutArr(a, n);
                Console.WriteLine("Для выхода нажмите Esc или любую другую кнопку, чтобы продолжить.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
