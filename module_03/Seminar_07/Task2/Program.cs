using System;

namespace Task2
{
    struct Coords
    {
        double x;
        double y;
        public Coords(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x = {x:f2} y = {y:f2}";
        }
    }

    class Circle
    {
        Coords centre;
        double radius;

        public Circle(double x, double y, double radius)
        {
            centre = new Coords(x, y);
            this.radius = radius;
        }

        public override string ToString()
        {
            return $"Centre: {centre}  radius = {radius:f2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Circle c1 = new Circle(r.Next(15)+r.NextDouble(), r.Next(15) + r.NextDouble(), r.Next(15) + r.NextDouble());
            Circle c2 = new Circle(r.Next(15) + r.NextDouble(), r.Next(15) + r.NextDouble(), r.Next(15) + r.NextDouble());
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
