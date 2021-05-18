//В некоторой коллекции хранятся целые числа. Вводите n с клавиатуры и генерируете последовательность от -10000 до 10000.
//Все выражения составить в форме запросов и в форме методов расширений.
//1) Составить LINQ-выражение, формирующее коллекцию, содержащую их последние цифры.
//2) Сгруппировать коллекцию по последней цифре.
//3) Составить запрос, формирующий коллекцию четных положительных чисел и выводит их количество
//4) Составить запрос, находящий сумму всех четных чисел
//5) Составить запрос, который сортирует числа по 1 и по последней цифре числа

using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = r.Next(-10000, 10001);
            Array.ForEach(arr, x => Console.Write($"{x} "));
            Console.WriteLine();
            var last = from i in arr
                       select i % 10;

            foreach (var a in last)
                Console.Write($"{a} ");
            Console.WriteLine();
            var sort = from i in arr                       
                       orderby i % 10
                       select i;
            foreach (var a in sort)
                Console.Write($"{a} ");
            Console.WriteLine();

            var k = (from i in arr
                     select i > 0 && i % 2 == 0).Count();
            Console.WriteLine(k);
            var z = arr.Aggregate((x, y) => x + y);
            Console.WriteLine(z);
            var final = arr.OrderBy(x => (int)((Math.Abs(x)).ToString()[0]-'0')).ThenBy(x => x % 10).ToList();
            final.ForEach(x => Console.Write($"{x} "));
                        
        }
    }
}
