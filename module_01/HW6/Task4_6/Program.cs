using System;

namespace Task4_6
{
    class Program
    {
        public static void Gen(int[,] a, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                    a[i, j] = r.Next(min, max + 1);
            }

        }
        public static void OutArr(int[,] a, int n,int n1)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write( "{0:00} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static int Det2(int[,] a,int k)
        {
            return (a[0, 0+k] * a[1, 1 + k] * a[2 , 2 + k] + a[1 , 0 + k] * a[2 , 1 + k] * a[2, 0 + k] + a[0, 1 + k] * a[1 , 2 + k] * a[2  , 0 + k]) - (a[0, 2 + k] * a[1 , 1 + k] * a[2 , 0 + k] + a[1 , 0 + k] * a[0 , 1 + k] * a[2 , 2 + k] + a[0 , 0 + k] * a[2, 1 + k] * a[1, 2 + k]);
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine();
                int[,] a = new int[3, 6];
                Gen(a, 0, 20);
                OutArr(a,3,6);
                int[] b = new int[2];
                b[0] =Det2(a,0);
                b[1] = Det2(a, 3);
                Console.WriteLine("b[0]={0}  b[1]={1}", b[0], b[1]);
                Console.WriteLine("Для выхода нажмите Esc. Чтобы продолжить, нажмите любую другую кнопку");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
