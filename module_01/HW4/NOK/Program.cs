using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Написать программу, которая по двум целым неотрицательным числам A и B возвращает их наибольший общий делитель (НОД) и наименьшее общее кратное (НОК)
                Для вычисления НОД и НОК использовать один метод, откуда НОД и НОК вернуть, используя out-параметры



     Дата:        2020.09.30
*/
namespace NOK
{
    class Program
    {
        public static void Nok(int a, int b, out int nod, out int nok)
        {
            int a1 = a, b1 = b;
            while (a1 != b1)
            {
                if (a1 > b1)
                    a1 -= b1;
                else
                    b1 -= a1;
            }
            nod = a1;
            nok = (a * b / nod);
        }
        static void Main(string[] args)
        {
            do
            {
                int nok, nod;
                int a;
                int b;
                do
                {
                    Console.WriteLine("Введите a");
                } while ((!(int.TryParse(Console.ReadLine(), out a))) | (a <= 0));
                do
                {
                    Console.WriteLine("Введите b");
                } while ((!(int.TryParse(Console.ReadLine(), out b))) | (b <= 0));
                Nok(a, b, out nod, out nok);
                Console.WriteLine("НОК = {0}, а НОД = {1}", nok, nod);
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
