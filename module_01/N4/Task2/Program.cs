using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:  
Написать метод, вычисляющий значение функции G=F(X,Y) 𝐺={(𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0;
                                                        𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0;
                                                        0.5∙𝑋∙𝑌, в остальных случаях)┤


     Дата:        2020.09.23
*/
namespace Task2
{
    class Program
    {
        public static double G(double x, double y)//Метод для вычисления функции
        {
            return (x < y) & (x > 0) ? x + Math.Sin(x) : (((x > y) & (x < 0)) ? y - Math.Cos(x) : 0.5 * x * y);
        }
        static void Main(string[] args)
        {
            double x, y;
            string str, a = "";
            while (a != "1")
            {
                do
                {
                    Console.Write("x = ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out x));//Преобразуем строку в число 
                do
                {
                    Console.Write("y = ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out y));//Преобразуем строку в число
                Console.WriteLine(G(x, y));//Ввод значения функции
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a = Console.ReadLine();
            }
        }
    }
}
