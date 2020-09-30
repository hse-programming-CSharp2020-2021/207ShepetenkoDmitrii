using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    8.1. Написать метод формирования массива из N вещественных элементов, значения элементов массива вычисляются по формуле:
                𝑎_𝑖=(𝑖(𝑖+1))/2  % N;  i = 0, 1, 2, 3, …, (N-1)
                8.2. Написать метод нормировки элементов вещественного массива путем деления каждого элемента на значение максимального по модулю элемента.
                8.3. Написать метод вывода на экран значений элементов вещественного массива с точностью до трёх знаков после запятой.
                8.4. В основной программе получать от пользователя значение N, формировать и нормировать массив. Исходный и нормированный массивы выводить на экран. 


     Дата:        2020.09.30
*/
namespace task8
{

    class Program
    {
        public static void Form(double[] arr, int n)
        {

            for (double i = 0; i < n; i++)
            {
                arr[(int)i] = (i * (i + 1) / 2) % (double)n;
            }
        }
        public static void Outarr(double[] arr)
        {
            foreach (double i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        public static void Outarr1(double[] arr)
        {
            foreach (double i in arr)
            {
                Console.Write("{0:f3} ", i);
            }
            Console.WriteLine();
        }
        public static void Norm(double[] arr)
        {
            double a = Max(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] /= a;
            }
        }
        public static double Max(double[] arr)
        {
            double max = double.MinValue;
            foreach (double i in arr)
            {
                max = (i > max) ? i : max;
            }
            return max;
        }
        static void Main(string[] args)
        {
            do
            {
                int n;
                do
                {
                    Console.WriteLine("Введите n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n <= 0));
                double[] arr = new double[n];
                Form(arr, n);
                Outarr(arr);
                Norm(arr);
                Outarr1(arr);
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
