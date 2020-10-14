using System;
using System.IO;
using System.Text;

namespace N3
{
    class Program
    {
        public static void Writebefore(string fileName, Encoding enc)
        {
            string[] messages = File.ReadAllLines(fileName, enc);
            Console.WriteLine(Environment.NewLine + "Переписка до форматирования:");
            foreach (string item in messages)
                Console.WriteLine(item);
        }
        public static void Writeafter(string fileName, Encoding enc,int linesCount)
        {
            Random rand = new Random();
            Console.WriteLine("Переписка после форматирования:");
            for (int i = 0; i < linesCount; i++)
            {
                string message = string.Empty;
                int length = rand.Next(20, 51);
                for (int j = 0; j < length; j++)
                {
                    message += (char)rand.Next('А', 'Я');
                }
                message += "." + Environment.NewLine;
                File.AppendAllText(fileName, message, enc);
                Console.Write(message.Substring(0, message.Length - 3) + "\n");

            }
        }
        static void Main(string[] args)
        {
            
            const string fileName = "dialog.txt";
            Encoding enc = Encoding.Unicode;
            const int linesCount = 6;
            File.WriteAllText(fileName, string.Empty, enc);
            Writeafter(fileName, enc, linesCount);
            Writebefore(fileName, enc);

        }
    }
}
