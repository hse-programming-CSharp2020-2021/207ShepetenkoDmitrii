using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    9.1. Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.
            9.2. В основной программе объявить и инициализировать массив; получить от пользователя число, заменить им все вхождения максимального элемента в массив.
            Исходный и изменённый массивы вывести на экран.



     Дата:        2020.09.30
*/
namespace Task81
{
    class Program
    {
        public static double[] Gen()
        {
            Random r = new Random();
            int n = r.Next(1, 25);
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (double)r.Next(1, 100) / 3;
            }
            return arr;
        }
        public static void Outarr(double[] arr)
        {
            foreach (double i in arr)
            {
                Console.Write("{0:0.0} ", i);
            }
            Console.WriteLine();
        }
        public static double Max(double[] arr)
        {
            double max = double.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                max = (arr[i] > max) ? arr[i] : max;
            }
            return max;
        }
        public static void Change(double[] arr, double a)
        {
            double m = Max(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (arr[i] == m) ? a : arr[i];
            }
        }

        static void Main(string[] args)
        {
            do
            {
                double a;
                do
                {
                    Console.WriteLine("Введите a");
                } while (!double.TryParse(Console.ReadLine(), out a));
                double[] arr = Gen();
                Outarr(arr);
                Change(arr, a);
                Outarr(arr);
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
