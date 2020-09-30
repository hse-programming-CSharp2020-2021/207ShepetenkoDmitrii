using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры. 
    Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения
     Дата:        2020.09.30
*/
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                long n1 = 1;
                int n, m;
                do
                {
                    Console.WriteLine("введите такие n и m, чтобы их сумма была меньше 63");
                    do
                    {
                        Console.WriteLine("введите n, не превышающее 63 и не меньше 0");
                    } while (!int.TryParse(Console.ReadLine(), out n) | (n > 63) | (n < 0));
                    do
                    {
                        Console.WriteLine("введите m, не превышающее 63");
                    } while (!int.TryParse(Console.ReadLine(), out m) | (m > 63) | (m < 0));
                } while (n + m >= 63);
                Console.WriteLine((n1 << n) + (n1 << m));
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
