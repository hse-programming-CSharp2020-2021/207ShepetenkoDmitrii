using System;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"[a-hA-H][1-8]-[a-hA-H][1-8]");

            string s = Console.ReadLine();
            foreach (Match i in r.Matches(s))
                Console.WriteLine(i.Value);
        }
    }
}
