using System;

namespace Task4_1._3
{
    class Program
    {
        public static void OutArr2(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0:D2} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Superfill(int[,]a,int n)
        {
            int k = 0,z=1,i=0,j=0,u1=0,u2=1;
            for(int u=0;u<2*n-1;u++)
            {
                while((i<n)&(j<n)&(i>=0)&(j>=0))
                {
                    if (a[i, j] == 0)
                    {
                        a[i, j] = z;
                        z++;
                    }
                    else
                        break;
                    i += u1;
                    j += u2;
                }
                i -= u1;
                j -= u2;
                k++;
                switch(k%4)
                {
                    case 0:
                        u1 = 0;
                        u2 = 1;
                        break;
                    case 1:
                        u1 = 1;
                        u2 = 0;
                        break;
                    case 2:
                        u1 = 0;
                        u2 = -1;
                        break;
                    case 3:
                        u1 = -1;
                        u2 = 0;
                        break;
                }
                i += u1;
                j += u2;

            }
        }
        static void Main(string[] args)
        {
            do
            {
                int n;
                do
                {
                    Console.WriteLine("Введите  n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1));
                int[,] a = new int[n, n];
                Superfill(a, n);
                OutArr2(a, n);
                Console.WriteLine("Для выхода нажмите Esc, иначе - другую кнопку");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
