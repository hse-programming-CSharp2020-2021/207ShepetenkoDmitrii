using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:     Написать метод для расчета сложных процентов. 
               Параметры: начальный капитал, годовая процентная ставка, число лет (вклада). 
               Возвращаемое значение – итоговая сумма в конце срока вклада. 
                static double Total(double k, double r, uint n)

В основной программе ввести начальный капитал (больший нуля), процентную ставку и число лет
Вывести таблицу значений итоговых сумм в конце каждого года вплоть до заданного числа лет.


     Дата:        2020.09.23
*/
namespace N6
{
    class Program
    {
        public static double Total(double k, double r, int n)//Метод для вычисления итоговой суммы на каждый год
        {
            for (int i = 1; i <= n; i++)
            {
                k *= (1 + r);
                Console.WriteLine("{0} год: {1}", i, k);
            }
            return k;
        }
        static void Main(string[] args)
        {
            double nachk, stavka;
            int let;
            string str, a = "";
            while (a != "1")
            {
                do
                {
                    Console.Write("Начальный капитал= ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out nachk) | (nachk <= 0));//Преобразуем строку в число
                do
                {
                    Console.Write("Ставка = ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!double.TryParse(str, out stavka) | (stavka > 1) | (stavka < 0));//Преобразуем строку в число
                do
                {
                    Console.Write("Кол-во лет= ");
                    str = Console.ReadLine();//Читаем символьную строку
                } while (!int.TryParse(str, out let) | (let <= 0));//Преобразуем строку в число
                Console.WriteLine("Итоговая сумма = {0}", Total(nachk, stavka, let));
                Console.WriteLine("Для выхода нажмите 1, иначе - другой символ");
                a = Console.ReadLine();
            }
        }
    }
}
