using System;

namespace Task2
{
        class Point:IComparable<Point>
        {
            public double x;
            public double y;
            public virtual void Display()
            {
                Console.WriteLine($"x = {x:f2}  y = {y:f3}");
            }
            public virtual double Area()
            {
                return 0;
            }

        public int CompareTo(Point obj)
        {
            return this.Area().CompareTo(obj.Area());
        }

        }
        class Circle:Point
        {
            double rad;
            public double Rad
            {
                get
                {
                    return rad;
                }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Радиус должен быть неторицательным числом");
                    rad = value;
                }
            }
            public Circle (double xx, double yy,double r)
            {
                x = xx;
                y = yy;
                Rad = r;
            }
            public override void Display()
            {
                Console.WriteLine($"x = {x:f3} y = {y:f3} R = {rad:f3} S = {Area():f3} L = {Len():f3}") ;
            }
            public override double Area()
            {
                return Math.PI * rad * rad;
            }
            public double Len()
            {
                return 2 * Math.PI * rad;
            }
        }
        class Square:Point
        {
            double side;
            public double Side
            {
                get
                {
                    return side;
                }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Сьорона должна быть неторицательным числом");
                    side = value;
                }
            }
            public Square(double xx, double yy, double s)
            {
                x = xx;
                y = yy;
                Side = s;
            }
            public override double Area()
            {
                return Math.Pow(side, 2);
            }
            public double Len()
            {
                return 4 * side;
            }
            public override void Display()
            {
                Console.WriteLine($"x = {x:f3} y = {y:f3} side = {side:f3} S = {Area():f3} L = {Len():f3}");
            }
        }
    
    class Program
    {
        public static Point[] FigArray(int n)
        {
            Random r = new Random();
            Point[] arr = new Point[n];
            for(int i = 0; i < arr.Length; i++)
            {
                if (r.Next(0, 2) == 1)
                    arr[i] =new Circle(r.Next(10, 100) + r.NextDouble(), r.Next(10, 100) + r.NextDouble(), r.Next(10, 100) + r.NextDouble());
                else
                    arr[i]=new Square(r.Next(10, 100) + r.NextDouble(), r.Next(10, 100) + r.NextDouble(), r.Next(10, 100) + r.NextDouble());
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Point[] p = FigArray(new Random().Next(1, 13));
            int s1 =0, s2 = 0;
            foreach(var a in p)
            {
                if (a is Circle)
                    s1++;
                else
                    s2++;
            }
            Console.WriteLine($"Кругов = {s1}");
            foreach(var a in p)
            {
                if (a is Circle)
                    a.Display();
            }
            Console.WriteLine($"Квадратов = {s2}");;
            foreach (var a in p)
            {
                if (!(a is Circle))
                    a.Display();
            }
            Array.Sort(p);
            foreach(var i in p)
            {
                Console.Write(i.Area()+" ");
            }
        }
    }
}


