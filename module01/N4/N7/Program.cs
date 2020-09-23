using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:     Написать метод для решения квадратного уравнения. 
    Параметры – коэффициенты уравнения А, В, С, и два параметра, для получения значений вещественных корней. 

    При отсутствии вещественных корней (если А=В=С=0 или А=В=0 и С!=0) метод должен возвращать в точку вызова значение false, иначе - true. 

    В основной программе вводить коэффициенты квадратного уравнения, выводить значения вещественных корней или сообщение об их отсутствии.


     Дата:        2020.09.23
*/
namespace N7
{
    class Program
    {
        public static void Solve(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;//Вычисляем дискриминант
            //Находим значение корней или то, что их нет
            string x1 = ((a == 0) & (b == 0) & (c == 0)) ? "Бесконечно" : ((d < 0) | ((a == 0) & (b == 0) & (c != 0))) ? "Нет" : ((a == 0) ? Convert.ToString(-c / b) : (Convert.ToString((-b + Math.Sqrt(d)) / (2 * a))));
            string x2 = ((a == 0) & (b == 0) & (c == 0)) ? "много" : ((d < 0) | ((a == 0) & (b == 0) & (c != 0))) ? "корней" : ((d == 0) | (a == 0)) ? "" : Convert.ToString((-b - Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("{0} {1}", x1, x2);
        }
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

                Solve(a, b, c);//Вызов метода для вывода корней уравнения
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a1 = Console.ReadLine();
            }
        }
    }
}
