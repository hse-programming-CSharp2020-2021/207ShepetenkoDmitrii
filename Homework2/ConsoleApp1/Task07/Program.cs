using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
    Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
    Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную часть из числа.

     Дата:        2020.09.23
*/

namespace Task07
{
    class Program
    {
        public static void Po_chastam(double a)//Выполнение первого метода задачи
        {
            if (a > 0)
                Console.WriteLine("{0}  {1}", Math.Floor(a), a - Math.Floor(a));
            else
                Console.WriteLine("{0}  {1}", Math.Floor(a) + 1, a - Math.Floor(a) - 1);
        }

        public static void Sqr_sqrt(double a)//Выполнение второго метода задачи
        {
            if (a >= 0)
                Console.WriteLine("{0}  {1}", a * a, Math.Sqrt(a));
            else
                Console.WriteLine(a * a);
        }

        static void Main(string[] args)
        {
            double a;
            string str, a1 = "";
            while (a1 != "1")
            {
                do
                {
                    Console.Write("Введите число: ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out a));//Преобразуем строку в число
                //Далее выполняем оба метода
                Po_chastam(a);
                Sqr_sqrt(a);
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a1 = Console.ReadLine();
            }
        }
    }
}
