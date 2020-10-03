using System;
using System.Security.Cryptography.X509Certificates;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    3.1. Написать метод, формирующий и возвращающий массив из N членов разложения в ряд функции sin(1):  
	            sin(x)= x - x3/3! + x5/5! - ... 
                Параметр N – число требуемых членов ряда.

                3.2. Написать метод для вычисления sin(х) для заданного х   с использованием массива членов ряда sin(1). 
                Параметры: ссылка на массив разложения sin(1) и аргумент х.
 
                3.3. В основной программе ввести значение N вычислить массив sin(1). Вводя, последовательно вводя, значения х, 
                вычислять sin(х) как с помощью созданного метода, так и с использованием библиотечного метода Math.Sin(). Сравнить результаты. 




     Дата:        2020.10.3
*/
namespace N3
{
    class Program
    {
        
        public static double[] Sinus1(int n)
        {
            double x = 1;
            double[] sinus1 = new double[n];
            double sin, mm, sin1;
            sin = x;
            mm = x;
            sin1 = 0;
            sinus1[0] = x;
            for (int m = 1;(m<sinus1.Length); m++)
            {
                
                sin1 = sin;
                mm *= -x * x / ((2 * m) * (2 * m + 1));
                sin += mm;
                sinus1[m ] = sin;
            }
            return sinus1;
        }
        public static double Sinus(double x)
        {
            double sin = x, mm = x, sin1 = 0; 
            for (int i=1;sin!=sin1;i++)
            {
                sin1 = sin;
                mm *= -x * x / ((2 * i) * (2 * i + 1));
                sin += mm;
            }
            return sin;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введите n");
            } while (!int.TryParse(Console.ReadLine(), out n)|(n<=1));
            double[] a = Sinus1(n);
            foreach(double i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            double x;
            do
            {
                Console.WriteLine("Введите x");
            } while (!double.TryParse(Console.ReadLine(), out x));
            Console.WriteLine("Посчитанный "+Sinus(x)+"   Через Math "+Math.Sin(x));
        }
    }
}
