using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("txt.txt", FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                fs.Read(b, 0, b.Length);
                string s = System.Text.Encoding.Default.GetString(b);
                foreach (char i in s)
                    if (i >= '0' && i <= '9')
                        Console.Write($"{i} ");
            }            
        }
    }
}
