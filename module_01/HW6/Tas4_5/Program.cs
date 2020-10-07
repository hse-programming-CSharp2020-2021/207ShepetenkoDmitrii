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
        public static void Fill1(char[,] a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i > j) & (i < (n - j - 1)))
                        a[i, j] = '@';
                    else
                        a[i, j] = 'a';
                }
            }
        }
       /* public static void Fill2(char[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                }
            }
        }
        public static void Fill3(char[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                }
            }
        }
        public static void Fill4(char[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                }
            }
        }*/
        static void Main(string[] args)
        {
            char[,] a = new char[6, 6];
            Fill1(a, 6);
            OutArr(a, 6);
        }
    }
}