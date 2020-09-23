using System;

/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:     Ввести значение x и вывести значение полинома: F(x) = 12x4 + 9x3 - 3x2 + 2x – 4. Не применять возведение в степень. Использовать минимальное количество операций умножения. 
     Дата:        2020.09.23
*/

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            string a = "";
            while (a != "1")
            {
                string str;
                do
                {
                    Console.Write("x= ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out x));//Преобразуем строку в число

                Console.WriteLine("F(x)= " + (12 * x * (x + 1) * (x - 0.25) * x + 2 * (x - 2)));//Находим значение функции
                Console.WriteLine("Для выхода из программы нажмите 1, иначе - другой символ ");
                a = Console.ReadLine();
            }
        }
    }
}
