using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> s = new Stack<char>();
            string str = Console.ReadLine();
            try
            {
                foreach (char i in str)
                {
                    if ((i == ')') || (i == ']') || (i == '}'))
                    {
                        if (s.Count == 0)
                            throw new Exception();
                        else
                        {
                            char l = s.Pop();
                            if (!((l == '(') & (i == ')')) & !((l == '[') & !(i == ']')) || ((l == '{') & (i == '}')))
                                throw new Exception();
                        }
                    }
                    else
                    {
                        if (!"({[".Contains(i))
                            throw new Exception();
                        else
                            s.Push(i);
                    }                        
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Не верно");
            }
            if (s.Count > 0)
                Console.WriteLine("Не верно");
            else
                Console.WriteLine("Верно");
        }
    }
}
