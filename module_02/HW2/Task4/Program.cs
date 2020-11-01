using System;

namespace Task4
{
    class Supernum
    {
        uint number;
        char[] othernum;
        public Supernum(uint n)
        {
            number = n;
            othernum = series(n);
        }
        public Supernum() : this(0) { }
        public uint Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                othernum = series(value);
            }
        }
        public char[] Othernum
        {
            get
            {
                return othernum;
            }
        }
        public string Record
        {
            get
            {
                string s = new String(othernum);
                return "0x" + s;
            }
        }
        char[] series(uint number)
        {
            int l = (number == 0) ? 1 : (int)Math.Log(number, 16) + 1;
            char[] a = new char[l];
            for(int i=l-1;i>=0;i--)
            {
                uint x = (uint)(number % 16);
                if ((x >= 0) & (x <= 9))
                    a[i] = (char)('0' + x);
                else
                    a[i] = (char)('A' + x % 10);
                number/= 16;
            }
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Supernum s = new Supernum(151);
                uint n;
                do
                {
                    Console.WriteLine("Введите число");
                } while (!uint.TryParse(Console.ReadLine(), out n));
                s.Number = n;
                Console.WriteLine("Число - "+s.Number);
                Console.WriteLine("Шестнадцатиричные цифры числа: ");
                foreach (char a in s.Othernum)
                    Console.Write(a);
                Console.WriteLine();
                Console.WriteLine("Шестнадцатиричная запись: " + s.Record); ;
                Console.WriteLine("Для выхода нажмите Esc");
            } while (Console.ReadKey().Key!= ConsoleKey.Escape);
        }
    }
}
