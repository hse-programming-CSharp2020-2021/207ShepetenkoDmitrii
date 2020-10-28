using System;

namespace Task1
{
    class Polygon
    {
        int n;
        double r;
        public Polygon(int n1=3,double r1=1)
        {
            n = n1;
            r = r1;
        }
        public double Per
        {
            get
            {
                return 2 * r * n * Math.Tan(Math.PI / n);
            }
        }
        public double Area
        {
            get
            {
                return r *r* n * Math.Tan(Math.PI / n);
            }
        }
        public string PolygonData()
        {
            string s =  "Кол-во сторон = "+n+" Радиус впис. окр. = "+r+" Периметр = "+Per+" Площадь = "+Area;
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n1,n;
                double r;
                do
                {
                    Console.WriteLine("Введите количество многоугольников");
                } while (!int.TryParse(Console.ReadLine(), out n1) | (n1 < 1));
                Polygon[] a = new Polygon[n1];
                for(int i=0;i<n1;i++)
                {
                    do
                    {
                        Console.WriteLine("Введите количество сторон многоугольника");
                    } while (!int.TryParse(Console.ReadLine(), out n) | (n < 3));
                    do
                    {
                        Console.WriteLine("Введите радиус вписанной окружности");
                    } while (!double.TryParse(Console.ReadLine(), out r) | (r < 0));
                    a[i] = new Polygon(n, r);
                }
                foreach (Polygon u in a)
                    Console.WriteLine(u.PolygonData());
                Console.WriteLine("Для выходаажмите Esc...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
    }
}
