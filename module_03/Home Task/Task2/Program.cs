using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static Street.Street StreetParse(string[] input)
        {
            int[] nums = new int[input.Length - 1];
            for (int i = 1; i < input.Length; i++)
                nums[i-1] = int.Parse(input[i]);
            return new Street.Street(input[0], nums);
        }
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\Task1\bin\Debug\netcoreapp3.1\out.txt";
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    while (true)
                    {
                        string s = sr.ReadLine();
                        if (s == null)
                            break;
                        Street.Street street = StreetParse(s.Split(' '));
                        if ((!street == true) && (~street % 2 == 1))
                            Console.WriteLine(street.ToString());                        
                    }                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error happend ({e.Message})"); 
            }
        }
    }
}
