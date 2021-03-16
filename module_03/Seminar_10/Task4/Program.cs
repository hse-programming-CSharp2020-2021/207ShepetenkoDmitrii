using System;
using System.Diagnostics.CodeAnalysis;
/*Объявить структуру Rectangle, описывающую прямоугольник, заданный длинами сторон.
Структура реализует интерфейс IComparable, сравнение структур происходит по величине площади прямоугольника.
Объявить класс Block3D, описывающий «кирпич», заданный основанием и высотой. Основание – объект структуры Rectangle.
Класс реализует интерфейс IComparable, сравнивая кирпичи по величине площади основания.
В основной программе протестировать работу методов классов, отсортировав массив элементов типа Block3D.*/
namespace Task4
{
    public  struct Rectangle:IComparable<Rectangle>
    {
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        double a;
        double b;

        public int CompareTo([AllowNull] Rectangle other)
        {
            if (a * b > other.a * other.b)
                return 1;
            else
            {
                if (a * b == other.a * other.b)
                    return 0;
                else
                    return -1;
            }                
        }
        public override string ToString()
        {
            return $"a - {a}  b - {b}";
        }
    }

    public class Block3D:IComparable<Block3D>
    {

        public Block3D(double a, double b, double h)
        {
            bottom = new Rectangle(a, b);
            this.h = h;
        }
        Rectangle bottom;
        double h;

        public int CompareTo([AllowNull] Block3D other)
        {
            return bottom.CompareTo(other.bottom);
        }
        public override string ToString()
        {
            return $"bottom: {bottom} h: {h}";
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            Random r = new Random();
            Block3D[] blocks = new Block3D[15];
            for (int i = 0; i < 15; i++)
            {
                blocks[i] = new Block3D(r.Next(1,15), r.Next(1,15), r.Next(1,15));
                Console.WriteLine(blocks[i]);
            }
            Console.WriteLine("\nSorted:\n");
            Array.Sort(blocks);
            foreach (var block in blocks)
                Console.WriteLine(block);

        }
    }
}
