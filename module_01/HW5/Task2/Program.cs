using System;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Пользователем с клавиатуры вводится целое число N > 0. В программе сформировать и вывести на экран целочисленный массив из N элементов, 
            элементами которого являются нечетные числа от 1. Заполнение массива нечётными числами организовать при помощи метода.

     Дата:        2020.09.30
*/
namespace Task2
{
    class Program
    {
        public static void Fill(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = 2 * i + 1;
        }
        public static void Outarr(int[] arr)
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
                    Console.WriteLine("Введите положительное n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n <= 0));
                int[] arr = new int[n];
                Fill(arr);
                Outarr(arr);
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
