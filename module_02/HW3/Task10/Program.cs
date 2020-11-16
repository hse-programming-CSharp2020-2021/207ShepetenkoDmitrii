using System;

namespace Task10
{
    class Circle
    {
        public double x { get; set; }
        public double y { get; set; }
        public double r { get; set; }
        public Circle(double x1,double y1,double r1)
        {
            x = x1;
            y = y1;
            r = r1;
        }
        public void Info()
        {
            Console.WriteLine($"x = {x}\ty = {y}\tr = {r}");
        }
    }
    class Program
    {
        public static bool Cross(Circle c1, Circle c2)
        {
            double d = Math.Sqrt((c1.x - c2.x) * (c1.x - c2.x) + (c1.y - c2.y) * (c1.y - c2.y));
            return (d < c1.r + c2.r);
        }
        static void Main(string[] args)
        {
            Circle[] a;
            do
            {
                int n;
                Random r = new Random();
                do
                {
                    Console.WriteLine("Введите n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1));
                a = new Circle[n];
                for(int i = 0; i < a.Length; i++)
                {
                    a[i] = new Circle(r.Next(1, 16), r.Next(1, 16), r.Next(1, 16));
                    a[i].Info();
                }
                Circle b = new Circle(5, 6, 2);
                Console.WriteLine();
                b.Info();
                Console.WriteLine();
                foreach(var z in a)
                {
                    if (Cross(z, b))
                        z.Info();
                }
                Console.WriteLine("Нажмите Esc, чтобы завершить программу...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
