using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. Оператор if не применять. Точность вывода три знака после запятой.

     Дата:        2020.09.23
*/
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string str, a1 = "";
            while (a1 != "1")
            {
                //Вводим стороны треугольника
                do
                {
                    Console.Write("a= ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out a) | (a < 0));//Преобразуем строку в число
                do
                {
                    Console.Write("b= ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out b) | (b < 0));//Преобразуем строку в число
                do
                {
                    Console.Write("c= ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out c) | (c < 0));//Преобразуем строку в число
                bool usl = (a < b + c) && (b < a + c) && (c < a + b);//Проверяем неравенство треугольника
                Console.WriteLine(usl);
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a1 = Console.ReadLine();
            }

        }
    }
}
