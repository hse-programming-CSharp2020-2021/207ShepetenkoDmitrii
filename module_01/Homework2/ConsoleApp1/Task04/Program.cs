using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:     Получить от пользователя четырехзначное натуральное число и напечатать его цифры в обратном порядке.

     Дата:        2020.09.23
*/
namespace Task04
{
    class Program
    {
        public static int Rever(int a)//Метод для переворачивания числа
        {
            int b = 0;
            while (a > 0)
            {
                b = b * 10 + a % 10;
                a /= 10;
            }
            return b;
        }
        static void Main(string[] args)
        {
            int a;
            string str, a1 = "";
            while (a1 != "1")
            {
                do
                {
                    Console.Write("Введите четырехзначное число число: ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!int.TryParse(str, out a) | (a < 1000) | (a > 9999));//Преобразуем строку в число

                Console.WriteLine(Rever(a));
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a1 = Console.ReadLine();
            }
        }
    }
}
