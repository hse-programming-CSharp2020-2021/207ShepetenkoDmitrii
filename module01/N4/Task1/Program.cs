using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:  
Написать метод, вычисляющий логическое значение функции G=F(X,Y). 
Результат равен true, если точка с координатами (X,Y) попадает в фигуру G,
и результат равен false, если точка с координатами (X,Y) не попадает в фигуру G.
Фигура G - сектор круга радиусом R=2 в диапазоне углов -90<= fi <=45.


     Дата:        2020.09.23
*/

namespace Task1
{
    class Program
    {
        public static bool Usl(double x, double y)//Метод для определения принадлежности точки к фигуре
        {
            if ((Math.Sqrt(x * x + y * y) <= 2) && ((Math.Atan(x / y)) >= (-Math.PI / 2) && ((Math.Atan(x / y)) <= (Math.PI / 4))))
                return true;
            else
                return false;
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
                Console.WriteLine(Usl(x, y));
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a = Console.ReadLine();
            }
        }
    }
}
