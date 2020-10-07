using System;

namespace Task3_11
{
    class Program
    {
        public static void Form(int[]a)
        {
            a[0] = 0;
            a[1] = 1;
            for(int i=2;i<a.Length;i++)
            {
                a[i] = 34 * a[i - 1] - a[i - 2] + 2;
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
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 2));
                int[] a = new int[n];
                Form(a);
                OutArr(a);
                Console.WriteLine("Для выхода из программы нажмите Esc, иначе - любую другую кнопку.");
            }while(Console.ReadKey().Key!=ConsoleKey.Escape);
        }
    }
}
