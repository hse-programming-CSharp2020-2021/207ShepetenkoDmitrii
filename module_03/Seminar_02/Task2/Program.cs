
using System;

namespace Task2
{
    delegate string ConvertRule(string s);
    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }
    class Program
    {
        static string RemoveDigits(string str)
        {
            string s = null;
            foreach(char c in str)
            {
                if ((c < '0') || (c > '9'))
                    s += c;
            }
            return s;
        }
        static string RemoveSpaces(string str)
        {
            string s = null;
            foreach (string i in str.Split(' '))
                s += i;
            return s;
        }
        static void Main(string[] args)
        {
            Converter c = new Converter();
            string[] strings = { "eugbeb eb bgeuig24 hg42g42g424g", "849nyc95 hg 5h7g5hgh57 ", "325325g4363646", "e r r o r" };
            ConvertRule c1 = RemoveDigits;
            ConvertRule c2 = RemoveSpaces;
            foreach (string i in strings)
            {
                Console.WriteLine($"String: {i} \tWithout Digits:{c.Convert(i,c1)}\t Without spaces: {c.Convert(i, c2)} \t Without all: {c.Convert(c.Convert(i, c1),c2)}");
            }
        }
    }
}
