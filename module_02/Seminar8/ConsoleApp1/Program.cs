using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double.Parse(null);
            }
            catch(ArgumentException )
            {
                Console.WriteLine('1');
            }
            try
            {
                string[] a = new string[] { "efe", "fefefe" };
                Array.Sort(a);
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine('2');
            }
            try
            {

            }
            catch
            {

            }
            try
            {

            }
            catch
            {

            }
            try
            {

            }
            catch
            {

            }
        }
    }
}
