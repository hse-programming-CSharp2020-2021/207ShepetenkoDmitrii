using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:     Ввести натуральное трехзначное число Р. Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.

     Дата:        2020.09.23
*/

namespace Task02
{
    class Program
    {
        public static int Max(int x1, int x2, int x3)//Метод нахождения наибольшего числа из трех
        { return ((x1 >= x3) & (x1 >= x2)) ? x1 : (x2 >= x3 ? x2 : x3); }
        public static int Min(int x1, int x2, int x3)//Метод нахождения наименьшего числа из треъ
        { return ((x1 <= x3) & (x1 <= x2)) ? x1 : (x2 <= x3 ? x2 : x3); }
        static void Main(string[] args)
        {
            string str, a = "";
            int r;
            while (a != "1")
            {
                do
                {
                    Console.Write("Введите число: ");
                    str = Console.ReadLine();
                } while (!int.TryParse(str, out r) | (r < 100) | (r >= 1000));//Вводим значение числа и проверяем его на верность
                                                                              //Теперь разбиваем его на составные цифры
                int x1 = r % 10;
                int x2 = r / 10 % 10;
                int x3 = r / 100;
                int max = Max(x1, x2, x3);//Находим максимальную цифру
                int min = Min(x1, x2, x3); //Находим минимальную цифру
                int other = x1 + x2 + x3 - min - max;//Оставшаяся цифра
                Console.WriteLine(max * 100 + other * 10 + min);//Вывод результата
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a = Console.ReadLine();
            }
        }
    }
}
