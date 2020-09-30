using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Пользователем с клавиатуры вводится целое число N > 0. В программе сформировать и вывести на экран целочисленный массив из N элементов. 
            Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2N-1). Заполнение массива степенями числа 2 организовать при помощи метода.

     Дата:        2020.09.30
*/
namespace Task1
{
    class Program
    {
        public static void Fill(long[] arr)
        {
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
                arr[i] = (arr[i - 1] << 1);
        }
        public static void Outarr(long[] arr)
        {
            foreach (long i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            do
            {
                int n;
                do
                {
                    Console.WriteLine("Введите положительное n меньшее 64");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n <= 0) | (n > 63));
                long[] a = new long[n];
                Fill(a);
                Outarr(a);
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
