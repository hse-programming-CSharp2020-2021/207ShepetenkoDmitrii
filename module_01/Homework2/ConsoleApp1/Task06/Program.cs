using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Получить от пользователя вещественное значение – бюджет пользователя и целое число – процент бюджета, выделенный на компьютерные игры.
    Вычислить и вывести на экран сумму в рублях\евро или долларах, выделенную на компьютерные игры. Использовать спецификаторы формата для валют.


     Дата:        2020.09.23
*/
namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, a = "";
            double value;
            int per;

            while (a != "1")
            {
                do
                {
                    Console.Write("Капитал = ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out value) | (value <= 0));//Преобразуем строку в число
                do
                {
                    Console.Write("Процент =  ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!int.TryParse(str, out per) | (per < 0) | (per > 100));//Преобразуем строку в число
                value = (value * per) / 100;
                Console.OutputEncoding = System.Text.Encoding.Unicode;//Сменил кодировку для вывода символа рубля в консоли

                Console.WriteLine("Деньги на игры: {0}", value.ToString("c"));
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a = Console.ReadLine();
            }
        }
    }
}
