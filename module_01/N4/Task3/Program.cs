using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:  
Написать метод, вычисляющий значение функции G=F(X) 𝐺=(sin⁡(𝜋/2),𝑋≤0.5
                                                        sin⁡((𝜋∙(𝑥−1))/2),𝑋>0.5)┤


     Дата:        2020.09.23
*/

namespace Task3
{
    class Program
    {
        public static double G(double x)//Метод для вычисления функции
        {
            return (x <= 0.5) ? Math.Sin(Math.PI / 2) : Math.Sin(Math.PI * (x - 1) / 2);
        }
        static void Main(string[] args)
        {
            double x;
            string str, a = "";
            while (a != "1")
            {
                do
                {
                    Console.Write("x = ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out x));//Преобразуем строку в число
                Console.WriteLine(G(x));
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a = Console.ReadLine();
            }

        }
    }
}
