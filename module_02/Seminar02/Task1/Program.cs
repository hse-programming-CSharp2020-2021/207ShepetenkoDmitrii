using System;

namespace Task1
{
    class Program
    {
        class Circle
        {
            double r;
            public double R
            {
                get
                {
                    return r;
                }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Радиус должен быть неотрицательным");
                    r = value;
                }
            }
            public Circle()
            {
                R = 1;
            }

            public Circle(double radius)
            {
                R = radius;
            }
            public double S
            {
                get
                {
                    return Math.PI * r * r;
                }
            }
            public double L
            {
                get
                {
                    return Math.PI * 2 * r;
                }
            }
        }
        public static double Rnd(double min,double max)
        {
            Random r = new Random();
            double z;
            do
            {
                 z = r.NextDouble() + r.Next((int)Math.Floor(min), (int)Math.Floor(max));
            } while ((z < min) | (z > max));
            return z;
        }
        static void Main(string[] args)
        {
            double max, min;
            int n;
            do
            {
                Console.WriteLine("Введите минимальное значение");
            } while (!double.TryParse(Console.ReadLine(), out min));
            do
            {
                Console.WriteLine("Введите максимальное значение");
            } while (!double.TryParse(Console.ReadLine(), out max));
            do
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out n));
            double maxs = 0;
            Circle[] c=new Circle[n];
            for (int i = 0; i < n; i += 1)
            {
                c[i] = new Circle(Rnd(min,max));
                Console.WriteLine($"Площадь = {c[i].S:f3} Длина = {c[i].L:f3} Радиус = {c[i].R:f3}");
                if (c[i].S > maxs)
                    maxs = c[i].S;
            }
            Console.WriteLine($"Максимальная площадь равана {maxs:f3}");
        }
    }
}
