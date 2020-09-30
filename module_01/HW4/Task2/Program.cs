﻿using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Пользователь последовательно вводит целые числа. Для хранения полученных чисел в программе используется одна переменная.
                Окончание ввода чисел определяется либо желанием пользователя, либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
                Определить и вывести на экран среднее арифметическое отрицательных чисел.


     Дата:        2020.09.30
*/
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string str = "";
                int a = 0, b = 0, c = 0, k = 0;
                while (k != 1)
                {
                    do
                    {
                        Console.WriteLine("Введите число, для заверешения ввода, введите 'stop'");
                        str = Console.ReadLine();
                        if (str == "stop")
                        {
                            k = 1;
                            str = "0";
                            break;
                        }

                    } while (!(int.TryParse(str, out a)));
                    if (k == 1)
                        break;
                    if (a < 0)
                    {
                        b += a;
                        c++;
                    }
                    if (b < -1000)
                        break;
                }
                if (c == 0)
                    c = 1;
                Console.WriteLine("Среднее арифметическое отрицательных цифр = {0}", (double)b / c);
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
