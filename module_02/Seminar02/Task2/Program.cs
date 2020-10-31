using System;

namespace Task2
{
    class LatinChar
    {
        char _char='a';
        public char Ch
        {
            get
            {
                return _char;
            }
            set
            {
                if (((value < 'a') | (value > 'z')) & ((value < 'A') | (value > 'Z')))
                    throw new ArgumentException("Символ не является латинской буквой");
                _char = value;
            }
        }
        public LatinChar()
        {
            Ch = 'a';
        }
        public LatinChar(char c)
        {
            Ch = c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char minChar, maxChar;
            do
            {

            } while (!char.TryParse(Console.ReadLine(), out minChar));
            do
            {

            } while (!char.TryParse(Console.ReadLine(), out maxChar));
            LatinChar z;
            for(char i=minChar;i<maxChar;i++)
            {
                z = new LatinChar(i);
                Console.WriteLine(z.Ch);
            }
        }
    }
}
