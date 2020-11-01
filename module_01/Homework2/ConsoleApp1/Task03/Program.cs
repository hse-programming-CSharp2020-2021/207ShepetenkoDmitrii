using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:     Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. Учесть (как хотите) возможность появления комплексных корней. Оператор if не применять.

     Дата:        2020.09.23
*/

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            string str, a1 = "";
            while (a1 != "1")
            {
                //Вводим коэффиценты
                do
                {
                    Console.Write("a= ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out a));//Преобразуем строку в число
                do
                {
                    Console.Write("b= ");
                    str = Console.ReadLine();
                } while (!double.TryParse(str, out b));
                do
                {
                    Console.Write("c= ");
                    str = Console.ReadLine();
                } while (!double.TryParse(str, out c));
                double d = b * b - 4 * a * c;//Вычисляем дискриминант
                //Находим значение корней или то, что их нет
                string x1 = ((a == 0) & (b == 0) & (c == 0)) ? "Бесконечно" : ((d < 0) | ((a == 0) & (b == 0) & (c != 0))) ? "Нет" : ((a == 0) ? Convert.ToString(-c / b) : (Convert.ToString((-b + Math.Sqrt(d)) / (2 * a))));
                string x2 = ((a == 0) & (b == 0) & (c == 0)) ? "много" : ((d < 0) | ((a == 0) & (b == 0) & (c != 0))) ? "корней" : ((d == 0) | (a == 0)) ? "" : Convert.ToString((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("{0} {1}", x1, x2);
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a1 = Console.ReadLine();
            }
        }
    }
}
