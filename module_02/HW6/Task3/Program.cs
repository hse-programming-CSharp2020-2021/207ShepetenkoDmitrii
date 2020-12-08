using System;
using static MyLib.Rename;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MyStrings testString;
                try
                {
                    testString = new RusString('ф','z', 11);
                    Console.WriteLine(testString);
                    Console.WriteLine(testString.CountLetter('о'));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Состояние объекта не изменено");
                }

                try
                {
                    testString = new RusString('в', 'я', 11);
                    Console.WriteLine(testString);
                    Console.WriteLine(testString.CountLetter('о'));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Состояние объекта не изменено");
                }

                try
                {
                    testString = new LatString('ф', 'z', 11);
                    Console.WriteLine(testString);
                    Console.WriteLine(testString.CountLetter('x'));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Состояние объекта не изменено");
                }

                try
                {
                    testString = new LatString('a', 'z', 11);
                    Console.WriteLine(testString);
                    Console.WriteLine(testString.CountLetter('p'));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Состояние объекта не изменено");
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }    
}
