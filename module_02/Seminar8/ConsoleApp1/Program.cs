using System;
using System.Text;

namespace Task1
{
    class Program
    {
        public static void Check(string s)
        {
            foreach (string i in s.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                foreach (char c in i)
                if ((c < 'а') || (c > 'я'))
                    throw new ArgumentException("Строка состоит не из русских букв");
        }
        public static string T1(string s)
        {
            Check(s.ToLower());
            return String.Join(" ", (s.Split(" ", StringSplitOptions.RemoveEmptyEntries)));
        }
        public static int T2(string s)
        {
            Check(s.ToLower());
            int k = 0;
            foreach (string i in s.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                if (i.Length > 4)
                    k++;
            return k;
        }
        
        public static int T3(string s)
        {
            Check(s.ToLower());
            int k = 0;
            char[] glass = new char[] { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'ё' };
            foreach (string i in s.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries))
                if (Array.IndexOf(glass,i[0])>=0)
                    k++;
            return k;
        }

        public static string T11(string s)
        {
            
            StringBuilder ss = new StringBuilder();
            ss.AppendJoin(' ', s.Split(" ", StringSplitOptions.RemoveEmptyEntries));
            return ss.ToString();
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            try
            {
                Console.WriteLine(T11(s));
                Console.WriteLine(T1(s));
                Console.WriteLine(T2(s));
                Console.WriteLine(T3(s));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
