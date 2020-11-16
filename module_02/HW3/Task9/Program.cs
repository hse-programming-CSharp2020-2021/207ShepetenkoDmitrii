using System;

namespace Task9
{
    class LinearEquation
    {
        double a;
        double b { get; set; }
        double c { get; set; }
        public LinearEquation(double x,double y, double z)
        {
            a = x;
            b = y;
            c = z;
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value == 0)
                    while (value == 0)
                        value = new Random().Next(-10, 11);
            }
        }
        public double Solve()
        {
            return (c - b) / a;
        }
        public void Info()
        {
            string z="";
            if (b < 0)
                z = $"- {b*-1}";
            if (b == 0)
                z = "";
            if (b > 0)
                z = $"+ {b}";
            Console.WriteLine($"{a}x {z}= {c}\nx = {Solve():f3}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation[] a;
            Random r = new Random();
            do
            {
                int n;
                do
                {
                    Console.WriteLine("Введите n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1));
                a = new LinearEquation[n];
                for(int i = 0; i < a.Length; i++)
                {
                    a[i] = new LinearEquation(r.Next(-10, 11), r.Next(-10, 11), r.Next(-10, 11));
                    a[i].Info();
                }
                for(int i = 0; i < a.Length - 1; i++)
                {
                    for(int j = 0;j < a.Length - i - 1; j++)
                    {
                        if (a[j].Solve() > a[j + 1].Solve())
                        {
                            LinearEquation x = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = x;
                        }
                    }
                }
                foreach (var b in a)
                    Console.Write($"{b.Solve():f3} ");
                Console.WriteLine("\nНажмите Esc, чтобы завершить...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
