using System;
using System.Linq;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:     4.1. Написать метод для формирования массива, целочисленные неотрицательные элементы которого вычисляются по следующему рекуррентному соотношению: ai+1 = ai%2==0 ? ai/2 :(3*ai+1). 
                Процесс вычисления завершается, когда ai+1 станет равным 1. 
                   Параметр метода задает значение a0. Количество элементов массива заранее не известно, так как определяется значением a0.
 
                    4.2. Написать метод вывода элементов массива в виде [индекс] = значение, размещая в строке по 5 элементов.

                        4.3 В основной программе, вводя значения a0, формировать массив и выводить его элементы на экран.



     Дата:        2020.10.3
*/
namespace N4
{
    class Program
    {
        public static int[] Gen(int a0)
        {
            int[] a = new int[1];
            a[0] = a0;
            if (a[0] == 1)
                return a;
            int u = 0,i=0;
            while(u!=1)
            {
                Array.Resize(ref a, a.Length+1);
                u = (a[i] % 2 == 0) ? a[i] / 2 : (3 * a[i] + 1);
                a[++i] = u;
            }
            return a;
        }
        public static void Outarr(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write("[{0}]={1}  ",i,a[i]);
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            do
            {
                int a0;
                do
                {
                    Console.WriteLine("Введите a0");
                } while (!int.TryParse(Console.ReadLine(), out a0) | (a0 < 1));
                int[] a = Gen(a0);
                Outarr(a);
                Console.WriteLine("Для завершения нажмите esc, иначе- другую кнопку.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
