using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:   Протабулировать функцию 𝑦 на заданном диапазоне, с заданным шагом изменения аргумента, значения 𝑎,𝑏,𝑐 вводит пользователь:
    𝑎𝑥^2+𝑏𝑥+𝑐, 𝑥<1,2
y={𝑎⁄𝑥+√(𝑥^2+1),𝑥=1,2      𝑥∈[1;2],∆𝑥=0,05┤ 
   (𝑎+𝑏𝑥))⁄√(𝑥^2+1),𝑥>1,2



     Дата:        2020.09.30
*/
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, n1 = 1.0, n2 = 2.01, d = 0.05;
            do
            {
                do
                {
                    Console.WriteLine("Введите a");
                } while (!(double.TryParse(Console.ReadLine(), out a)));
                do
                {
                    Console.WriteLine("Введите b");
                } while (!(double.TryParse(Console.ReadLine(), out b)));
                do
                {
                    Console.WriteLine("Введите c");
                } while (!(double.TryParse(Console.ReadLine(), out c)));
                for (double i = n1; i <= n2; i += d)
                {
                    if (i < 1.2)
                        Console.WriteLine("f({0:0.00}={1:0.000})", i, a * i * i + b * i + c);
                    if (i == 1.2)
                        Console.WriteLine("f({0:0.00}={1:0.000})", i, a / i + Math.Sqrt(i * i + 1));
                    if (i > 1.2)
                        Console.WriteLine("f({0:0.00}={1:0.000})", i, (a + b * i) / Math.Sqrt(i * i + 1));
                }
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
