using System;
using System.Linq;

namespace Task1
{
    class Program
    {        
        static void Main(string[] args)
        {
            uint n;
            do
            {
                Console.WriteLine("Введите кол-во чисел");
                if (uint.TryParse(Console.ReadLine(), out n))
                    break;
            } while (true);
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = r.Next(2001) - 1000;
            Array.ForEach(arr, x => Console.Write($"{x} "));
            Console.WriteLine();
            var a = from i in arr
                    select i * i;
            foreach (var i in a)
                Console.Write($"{i} ");
            Console.WriteLine();
            var b = from i in arr
                    where i >= 10 && i <= 99
                    select i;
            foreach (var i in b)
                Console.Write($"{i} ");
            Console.WriteLine();
            var c = arr.Where(x => x % 2 == 0).OrderByDescending(x=>x);
            foreach (var i in c)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
            var d = from i in arr
                    group i by Math.Abs(i).ToString().Length into gr
                    orderby gr.Key
                    select gr;
            foreach (var i in d)
            {
                Console.Write($"Порядок {i.Key}: ");
                foreach(var j in i)
                    Console.Write($"{j} ");
                Console.WriteLine();
            }
                
            Console.WriteLine();
        }
    }
}
