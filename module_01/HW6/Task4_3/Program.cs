using System;

namespace Task4_3
{
    class Program
    {
        public static void OutArr(char[][] a, int k)
        {
            for (int i = 0; i < k; i++)
            {
                foreach (char j in a[i])
                {
                    if (j != '*')
                        Console.Write(" ");
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Gen1(ref char[][]a, int n)
        {
            for(int i=0;i<n;i++)
            {
                a[i] = new char[i + 1];
                for (int j = 0; j < a[i].Length; j++)
                    a[i][j] = '*';
            }
        }
        public static void Gen2(ref char[][] a, int n)
        {
            int k = 2 * n - 1;
            int l = k;
            for (int i = n-1; i >=0; i--)
            {
                a[i] = new char[l];
                for (int j =a[i].Length-1; j >= a[i].Length-k; j--)
                    a[i][j] = '*';
                k -= 2;
                l--;
            }
        }
        static void Main(string[] args)
        {
            do
            {
                int n;
                do
                {
                    Console.WriteLine("Ввведите n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1));
                char[][] a = new char[n][];
                char[][] b = new char[n][];
                Gen1(ref a, n);
                OutArr(a,n);
                Gen2(ref b, n);
                OutArr(b, n);
                Console.WriteLine("Нажмите Esc для завершения, или другую кнопку, чтобы прододжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
