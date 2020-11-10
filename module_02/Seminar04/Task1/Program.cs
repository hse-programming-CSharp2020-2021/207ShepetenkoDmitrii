using System;

namespace Task1
{
    class Point
    {
        double x;
        double y;
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x,double y)
        {
            X = x;
            Y = y;
        }
        public Point()
        {
            X = 0;
            Y = 0;
        }
    }

    class Triangle
    {
        double AB;
        double BC;
        double AC;
        public Triangle()
        {
            AB = 1;
            BC = 1;
            AC = 1;
        }
        public Triangle(Point p1,Point p2,Point p3)
        {
            AB = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            BC = Math.Sqrt((p2.X - p3.X) * (p2.X - p3.X) + (p2.Y - p3.Y) * (p2.Y - p3.Y));
            AC = Math.Sqrt((p3.X - p1.X) * (p3.X - p1.X) + (p3.Y - p1.Y) * (p3.Y - p1.Y));
        }
        public Triangle(double x1,double y1, double x2, double y2, double x3, double y3)
        {
            AB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            BC = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            AC = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
        }
        public double P()
        {
            return AB + BC + AC;
        }
        public double S()
        {
            double p =P()/2;
            return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
        }
        public void Info()
        {
            Console.WriteLine($"AB = {AB:f3}, AC = {AC:f3}, BC = {BC:f3}\nP = {P():f3}\nS = {S():f3}");
        }
    }

    class Program
    {
        public static void Sort(ref Triangle[]a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j].S() < a[j + 1].S())
                    {
                        Triangle x = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = x;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Random r = new Random();
                Triangle[] a = new Triangle[r.Next(5, 16)];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = new Triangle(new Point((r.NextDouble() + r.Next(-10, 11)), (r.NextDouble() + r.Next(-10, 11))), new Point((r.NextDouble() + r.Next(-10, 11)), (r.NextDouble() + r.Next(-10, 11))), new Point((r.NextDouble() + r.Next(-10, 11)), (r.NextDouble() + r.Next(-10, 11))));
                    a[i].Info();
                }
                Sort(ref a);
                foreach (var s in a)
                    Console.Write($"{s.S():f3} ");
                Console.WriteLine("\nНажмите Esc, чтобы выйти...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
