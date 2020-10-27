using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] a = new char[3][][];
            a[0] = new char[3][];
            a[0][0] =new char[]{ 'a','b'};
            a[0][1] = new char[] { 'a', 'b','c' };
            a[0][2] = new char[] { 'a', 'b','c','d' };
            a[1] = new char[2][];
            a[1][0] = new char[] { 'q', 'w' };
            a[1][1] = new char []{ 'q', 'w','e' };
            a[2] = new char[1][];
            a[2][0] = new char[] { 'z','x','c','v'};
            foreach(char[][] z in a)
            {
                foreach(char[]zz in z)
                {
                    foreach(char zzz in zz)
                    {
                        Console.Write(zzz + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
