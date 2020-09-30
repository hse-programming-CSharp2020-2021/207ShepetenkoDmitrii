using System;
using System.ComponentModel.Design.Serialization;
/*
   Дисциплина: "Программирование"
   Группа:      БПИ207
   Студент:     Шепетенко Дмитрий Алексеевич
   Задача:    Пользователем с клавиатуры вводится целое число N > 1. В программе сформировать целочисленный массив,
                содержащий N первых элементов последовательности Фибоначчи: A[0] = 1, A[1] = 1, A[2] = A[0] + A[1], … A[K] = A[K-1] + A[K-2], …
                Формирование массива организовать при помощи метода. Элементы массива вывести на экран в обратном порядке, методы класса Array не использовать. 

     Дата:        2020.09.30
*/
namespace Task4
{
    class Program
    {
        public static void Fill(int[] arr)
        {
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
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
                int[] arr = new int[n];
                Fill(arr);
                Outarr(arr);
                Console.WriteLine("Для выхода нажмите Esc или другую клавишу чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
