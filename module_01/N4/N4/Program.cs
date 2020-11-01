using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:     Написать метод для вычисления по формуле Ньютона с точностью до «машинного нуля» приближенного значения арифметического квадратного корня. 
   Параметры: подкоренное значение, полученное значение корня и значение точности, достигнутой при его вычислении. Если подкоренное значение отрицательно - метод должен возвращать в точку вызова значение false, иначе - true. 

    В основной программе вводить вещественные числа и выводить их корни. При отрицательных числах выводить сообщения.

     Дата:        2020.09.23
*/

namespace HW_3
{
    class Program
    {
        static bool Newton(double x, out double sq, out double e)
        {
            double r1, r2 = x;
            sq = e = 0;
            if (x <= 0)
            {
                Console.WriteLine("Ошибка данных");
                return false;
            }
            do
            {
                r1 = r2;
                e = x / r1 / 2 - r1 / 2;
                r2 = r1 + e;
            } while (r1 != r2);
            sq = r2;
            return true;
        }
        static void Main(string[] args)
        {
            double x, res = 0, e = 0;
            Console.Title = "Формула Ньютона";
            ConsoleKeyInfo keyinfo;
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("x = ");

                } while (!double.TryParse(Console.ReadLine(), out x));
                if (!Newton(x, out res, out e))
                {
                    Console.WriteLine("Error");
                    return;
                }
                Console.WriteLine("root({0})={1,8:f4}, eps={2,8:e4}", x, res, e);
                Console.WriteLine("Для выхода нажмите ESC");
                keyinfo = Console.ReadKey(true);
            } while (keyinfo.Key != ConsoleKey.Escape);
            Console.Beep(500, 1000);

        }
    }
}
