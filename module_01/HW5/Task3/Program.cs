using System;
using System.Data;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Пользователем с клавиатуры вводятся целые числа N > 1, A и D. В программе сформировать и вывести на экран целочисленный массив из N элементов.
                Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D. Формирование массива организовать при помощи метода

     Дата:        2020.09.30
*/
namespace Task3
{
    class Program
    {
        public static void Fill(int[] arr, int a, int d)
        {
            arr[0] = a;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + d;
            }
        }
        public static void Outarr(int[] arr)
        {
            foreach (int i in arr)
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
                    Console.WriteLine("Введите положительное n>1");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n <= 1));
                int a;
                do
                {
                    Console.WriteLine("Введите a");
                } while (!int.TryParse(Console.ReadLine(), out a));
                int d;
                do
                {
                    Console.WriteLine("Введите d");
                } while (!int.TryParse(Console.ReadLine(), out d));
                int[] arr = new int[n];
                Fill(arr, a, d);
                Outarr(arr);
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
