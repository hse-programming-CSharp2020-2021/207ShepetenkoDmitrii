using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int k =int.Parse( Console.ReadLine());
            Console.WriteLine("1 - вывод от большего дестка, другое - от меньшего");
            int usl = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            LinkedList<int> ll = new LinkedList<int>();
            while (k > 0)
            {
                ll.AddLast(k % 10);
                stack.Push(k % 10);
                k /= 10;                
            }
            if(usl==1)
                foreach (int i in stack)
                    Console.Write(i + " ");
            else
                foreach (int i in ll)
                    Console.Write(i + " ");
        }
    }
}
