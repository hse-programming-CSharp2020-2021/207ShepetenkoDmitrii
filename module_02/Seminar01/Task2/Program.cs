using System;

namespace Task2
{
    class Program
    {
        public static void WriteArr(int[][]a)
        {
            foreach (int[] z in a)
            {
                foreach (int zz in z)
                    Console.Write(zz + " ");
                Console.WriteLine();
            }
        }
        public static void ArrForm(int n,out int[][]a)
        {
            a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[i + 1];
                if (i > 0)
                {
                    a[i][0] = 1;
                    a[i][i] = 1;
                    for (int j = 1; j < i; j++)
                        a[i][j] = a[i - 1][j - 1] + a[i - 1][j];
                }
                else
                {
                    if (i == 0)
                        a[0][0] = 1;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] a;
            ArrForm(n,out a);
            WriteArr(a);
            
        }
    }
}
