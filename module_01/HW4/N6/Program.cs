using System;
using System.Net;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Написать методы, вычисляющие суммы рядов с машинной точностью (если это возможно):
                𝑺=𝒙^𝟐−(𝟐^𝟑 𝒙^𝟒)/𝟒!+(𝟐^𝟓 𝒙^𝟔)/𝟔!−…
                𝑺=𝟏+𝒙/𝟏!+𝒙^𝟐/𝟐!+…+𝒙^𝒏/𝒏!+…

                Вещественные значения x получать от пользователя в основной программе.


     Дата:        2020.09.30
*/
namespace N6
{
    class Program
    {
        public static int F(int x)
        {
            if (x == 1)
                return 1;
            else return x * F(x - 1);
        }


        public static double Meth1(double x)
        {
            double s = x * x, s1 = 0, s2 = 0;
            int k = 0;
            for (int i = 4; !(double.IsNaN(s)); i += 2)
            {
                s2 = s1;
                s1 = s;
                k = (i % 4 == 0) ? 1 : 0;
                s += Math.Pow(-1, k) * Math.Pow(2, i - 1) * Math.Pow(x, i) / F(i);

            }
            return s2;
        }
        public static double Meth2(double x)
        {
            const double e = 0.00001;
            double s = 1, s1 = 0;
            int i = 1;
            while (s - s1 > e)
            {
                s1 = s;
                s += (Math.Pow(i, x) / F(i));
                i++;
            }
            return s;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double x;
                do
                {
                    Console.WriteLine("Введите x");
                } while (!(double.TryParse(Console.ReadLine(), out x)));
                Console.WriteLine(Meth1(x));
                Console.WriteLine(Meth2(x));
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
