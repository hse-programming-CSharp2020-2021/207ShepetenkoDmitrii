using System;

namespace Task2
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point(double x, double y) { X = x; Y = y; }
            public Point() : this(0, 0) { }

            public double Ro
            {
                get
                {
                    return Math.Sqrt(X * X + Y * Y);
                }
            }
            public double Fi
            {
                get
                {
                    if ((X > 0) & (Y >= 0))
                        return Math.Atan(Y / X);
                    if ((X > 0) & (Y < 0))
                        return Math.Atan(Y / X) + Math.PI * 2;
                    if (X < 0)
                        return Math.Atan(Y / X) + Math.PI;
                    if ((X == 0) & (Y > 0))
                        return Math.PI / 2;
                    if ((X == 0) & (Y < 0))
                        return Math.PI * 1.5;
                    return 0;
                }

            }
            public string PointData
            {
                get
                {
                    string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                    return string.Format(maket, X, Y, Ro, Fi);
                }
            }
        }
        static void Main(string[] args)
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                if ((a.Ro <= b.Ro) & (b.Ro <= c.Ro))
                {
                    Console.WriteLine(a.PointData);
                    Console.WriteLine(b.PointData);
                    Console.WriteLine(c.PointData);
                }
                if ((a.Ro <= c.Ro) & (c.Ro <= b.Ro))
                {
                    Console.WriteLine(a.PointData);
                    Console.WriteLine(c.PointData);
                    Console.WriteLine(b.PointData);
                }
                if ((b.Ro <= a.Ro) & (a.Ro <= c.Ro))
                {
                    Console.WriteLine(b.PointData);
                    Console.WriteLine(a.PointData);
                    Console.WriteLine(c.PointData);
                }
                if ((c.Ro <= a.Ro) & (a.Ro <= b.Ro))
                {
                    Console.WriteLine(c.PointData);
                    Console.WriteLine(a.PointData);
                    Console.WriteLine(b.PointData);
                }
                if ((c.Ro <= b.Ro) & (b.Ro <= a.Ro))
                {
                    Console.WriteLine(c.PointData);
                    Console.WriteLine(b.PointData);
                    Console.WriteLine(a.PointData);
                }
            } while (x != 0 | y != 0);
        }
    }
}

