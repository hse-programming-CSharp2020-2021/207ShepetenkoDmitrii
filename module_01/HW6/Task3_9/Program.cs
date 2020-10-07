using System;

namespace Task3_9
{
    class Program
    {
        
        public static void ArrayHill(double[]a,int x,int y,int u)
        {
            if(u==1)
            {
                Array.Sort(a,x,y-x+1);
            }
            else
            {
                Array.Sort(a, x, y - x+1);
                Array.Reverse(a, x, y - x+1);
            }

        }
        public static void OutArr(double[]a)
        {
            foreach(double i in a)
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
                    Console.WriteLine("Введите длину массива");
                } while (!int.TryParse(Console.ReadLine(), out n) | n <= 0);
                double[] a = new double[n];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    a[i] = r.Next(-10, 11);
                }
                OutArr(a);
                int x = 0, y = n-1, u = 1;
                while (x != y)
                {
                    ArrayHill(a, x, y, u);
                    if (u == 1)
                        x++;
                    else
                        y--;
                    u *= -1;
                }
                OutArr(a);
                Console.WriteLine("Для выхода нажмите Esc, иначе - другую кнопкую");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
