using System;
using System.IO;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int[] arr = new int[10];
            string s = "";
            string[] ss = new string[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = R.Next(15);
                s += $"{arr[i]} ";
                ss[i] = arr[i].ToString();
            }
            File.WriteAllText("f1.txt", s);
            using (FileStream fs = new FileStream("f2.txt", FileMode.OpenOrCreate))
            {
                byte[] arrayByte = System.Text.Encoding.Default.GetBytes(s);
                fs.Write(arrayByte, 0, arrayByte.Length);
            }
            using (StreamWriter sw = new StreamWriter("f3.txt"))
            {
                sw.WriteLine(s);
            }
            using (BinaryWriter bw = new BinaryWriter(File.OpenWrite("f4.txt")))
            {
                Array.ForEach(ss, x => bw.Write(x));
            }

            using (StreamReader sr = new StreamReader($"f1.txt"))
                Console.WriteLine(sr.ReadToEnd());
            using (StreamReader sr = new StreamReader($"f2.txt"))
                Console.WriteLine(sr.ReadToEnd());
            using (StreamReader sr = new StreamReader($"f3.txt"))
                Console.WriteLine(sr.ReadToEnd());
            using (StreamReader sr = new StreamReader($"f4.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
                

            
            using (BinaryReader bw = new BinaryReader(File.OpenRead("f4.txt")))
            {
                int sum = 0;
                while (bw.PeekChar() > -1)
                {
                    string line = bw.ReadString();
                    if (int.TryParse(line, out int number) && number % 2 == 0)
                        sum += number;
                }
                Console.WriteLine(sum);
            }


        }
    }
}