using System;

namespace Task3
{
    interface IFigure
    {
        public double Area { get; }
    }

    public class Square1 : IFigure
    {
        double side;

        public Square1(double side)
        {
            this.side = side;
        }

        public double Area { get { return side * side; } }

        public override string ToString()
        {
            return $"Side = {side}  Area = {Area}";
        }
    }

    public class Square2 : IFigure
    {
        double r;
        public Square2(double r)
        {
            this.r = r;
        }
        public double Area
        {
            get
            {
                return 4 * r * r;
            }
        }

        public override string ToString()
        {
            return $"Radius = {r}  Area = {Area}";
        }
    }

    class Program
    {
        static void Print<T>(T[] squares, double min) where T: IFigure
        {
            foreach (T figure in squares)
                if(figure.Area>=min)
                    Console.WriteLine(figure.Area);
        }
        static void Main(string[] args)
        {
            IFigure[] figures = new IFigure[] {new Square1(5), new Square2(2), new Square1(8), new Square2(15) };
            Array.ForEach(figures, x=>Console.WriteLine(x));
            Print<IFigure>(figures, 25);
        }
    }
}
