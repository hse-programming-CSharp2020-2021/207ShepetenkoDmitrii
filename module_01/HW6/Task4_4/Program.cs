using System;

namespace Task4_4
{
    class Program
    {
        public static void OutArr(int[,]a,int n)
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Gen(int[,]a,int min,int max)
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    a[i, j] = r.Next(min, max + 1);
            }

        }
        public static int Det1(int[,]a)
        {
            return a[0, 0] * a[1, 1] - a[1, 0] * a[0, 1];
        }
        public static int Det2(int[,] a)
        {
            return (a[0, 0] * a[1, 1]*a[2,2]+a[1,0]*a[2,1]*a[2,0]+a[0,1]*a[1,2]*a[2,0]) - (a[0, 2] * a[1, 1]*a[2,0]+a[1,0]*a[0,1]*a[2,2]+a[0,0]*a[2,1]*a[1,2]);
        }
        static void Main(string[] args)
        {
            do
            {
                int min, max;
                do
                {
                    Console.WriteLine("Введите min");
                } while (!int.TryParse(Console.ReadLine(), out min));
                do
                {
                    Console.WriteLine("Введите max");
                } while (!int.TryParse(Console.ReadLine(), out max));
                if(min>max)
                {
                    int u = max;
                    max = min;
                    min = u;
                }
                int[,] a = new int[3, 3];
                Gen(a,min,max);
                OutArr(a, 2);
                Console.WriteLine(Det1(a));
                OutArr(a, 3);
                Console.WriteLine(Det2(a));
                Console.WriteLine("Нажмите Esc для выхода, любую другую кнопку, чтобы продолжить.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
