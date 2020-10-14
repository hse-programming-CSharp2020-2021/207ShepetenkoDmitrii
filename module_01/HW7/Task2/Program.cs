using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool Parsing(string[] str, out int[] a)
        {
            a = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (!int.TryParse(str[i], out a[i]))
                    return false;
            }
            return true;
        }
        public static void Outing(int[]a,out int [] b)
        {
            b = new int[a.Length];
            for(int i=0;i<a.Length;i++)
            {
                int j = 0;
                while(true)
                {
                    if((int)Math.Pow(2,j)>a[i])
                    {
                        b[i] = (int)Math.Pow(2, j - 1);
                        break;
                    }
                    j++;
                }
            }
        }
        static void Main(string[] args)
        {

            string[] s = File.ReadAllLines("input.txt");
            string[] str = s[0].Split(' ');
            int[] a,b;

            List<string> incorr = new List<string> { "Incorrect input", };
            string[] outttt = new string[1];
            if (!Parsing(str, out a))
                File.WriteAllLines("output.txt", incorr);
            else
            {
                Outing(a, out b);
                for (int i = 0; i < b.Length; i++)
                    outttt[0] = outttt[0] + b[i].ToString() + " ";
                File.WriteAllLines("outuput.txt", outttt);
            }
        }
    }
}
