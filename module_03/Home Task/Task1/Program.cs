using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task1
{
    class Program
    {
        static bool Check(string[] input, List<Street.Street> s)
        {
            int n;
            List<int> k = new List<int>();
            if (input.Length <= 1)
                return false;
            for (int i = 1; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out n))
                    return false;
                if (n <= 0)
                    return false;
                k.Add(n);
            }
            s.Add(new Street.Street(input[0], k.ToArray()));
            return true;
        }

        static Street.Street[] CreateArray(int n)
        {
            Random r = new Random();
            Street.Street[] streets = new Street.Street[n];
            for (int i = 0; i < n; i++)
            {
                int[] nums = new int[r.Next(1, 10)];
                for (int j = 0; j < nums.Length; j++)
                    nums[j] = r.Next(1, 100);
                string name = "";
                for (int j = 0; j < r.Next(5, 10); j++)
                    name += (char)r.Next('a', 'z' + 1);
                streets[i] = new Street.Street(name, nums);
            }
            return streets;
        }

        static void Main(string[] args)
        {
            Street.Street[] streets;
            List<Street.Street> s = new List<Street.Street>();
            int n = 0;            
            do
            {
                Console.WriteLine("Введите n");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 1);
            bool flag = true;
            using (StreamReader sr = new StreamReader(new FileStream("data.txt", FileMode.Open)))
            {
                while (true)
                {
                    string input = sr.ReadLine();
                    if (input == null)
                        break;
                    if (!Check(input.Split(' '),s))
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (!flag)
            {
                Console.WriteLine("Некоррректные данные в файле(создаем новый массив)");
                streets = CreateArray(n);
            }
            else
            {
                if (s.Count >= n)
                {
                    streets = new Street.Street[n];
                    for (int i = 0; i < n; i++)
                        streets[i] = s[i];
                }
                else
                {
                    Console.WriteLine("Недостаточно строк в файле(создаем новый массив)");
                    streets = CreateArray(s.Count);
                }
            }
            using(StreamWriter sw = new StreamWriter(new FileStream("out.txt", FileMode.Create)))
            {
                foreach (Street.Street i in streets)
                    sw.WriteLine(i.ToString());
            }
        }
    }
}
