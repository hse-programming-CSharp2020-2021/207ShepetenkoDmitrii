using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    class Program
    {
        public static bool Parsing(string[]str,out int[]a)
        {
            a = new int[str.Length];
            for(int i=0;i<str.Length;i++)
            {
                if (!int.TryParse(str[i], out a[i]))
                    return false;
            }
            return true;
        }
        public static void Inning(int[]a,out bool[]u)
        {
            u = new bool[a.Length];
            for (int i = 0; i < a.Length; i++)
                u[i] = (a[i] >= 0) ? true : false;
        }
        static void Main(string[] args)
        {
            string[] s = File.ReadAllLines("input.txt");
            string[] str = s[0].Split(' ');
            int[] a;
            
            List<string> incorr = new List<string>{ "Incorrect input", };
            string[] outttt = new string[1];
            if (!Parsing(str, out a))
                File.WriteAllLines("output.txt", incorr);
            else
            {
                bool[] u;
                Inning(a,out u);
                for(int i=0;i<u.Length;i++)
                {
                    if(u[i])
                        outttt[0]= outttt[0]+"True ";
                    else
                        outttt[0] = outttt[0] + "False ";
                }
                File.WriteAllLines("output.txt", outttt);
            }
        }
    }
}
