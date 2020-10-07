using System;

namespace HW6
{
    class Program
    {
        public static void Fill1(int[,]a,int n)
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if (i == j)
                        a[i, j] = 0;
                    if (j > i)
                        a[i, j] = 1;
                    if (j < i)
                        a[i, j] = -1;
                }
            }
        }
        public static void Outarr(int[,]a,int n)
        {
            for (int i = 0; i<n; i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write("{0:0} ",a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n,n];
            Fill1(a, n);
            Outarr(a, n);
        }
    }
}
