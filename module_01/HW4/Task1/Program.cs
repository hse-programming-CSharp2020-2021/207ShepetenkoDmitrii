using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Определить все тройки попарно различных целых чисел 𝑎,𝑏,𝑐 из интервала [1;20], для которых верно 𝑎^2+𝑏^2=𝑐^2.

     Дата:        2020.09.30
*/
namespace Tasl1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    int k = i * i + j * j;
                    if (((int)Math.Sqrt(k) == (Math.Sqrt(k))) & (k <= 400))
                        Console.WriteLine("{0}^2+{1}^2={2}^2", i, j, Math.Sqrt(k));
                }
            }
        }
    }
}
