using System;

namespace Task4_2
{
    class Program
    {
        public static void OutArr(int[][]a,int k)
        {
            for(int i=0;i<k;i++)
            {
                foreach(int j in a[i])
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            do
            {
                int n,s=0,k=0,u=0;
                do
                {
                    Console.WriteLine("Введите n");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1));
                for(int i=1;i<n;i++)
                {
                    s += i;
                    k++;
                    if(s>n)
                    {
                        s -= i;
                        u = n - s;
                        break;
                    }
                    if (s == n)
                    {
                        u = i;
                        break;
                    }
                        
                }
                int[][] a = new int[k][];
                for(int i=0;i<k;i++)
                {
                    if(i==k-1)
                        a[i] = new int[u];
                    else
                        a[i] = new int[i + 1];
                    for(int j=0;j<a[i].Length;j++)
                    {
                        a[i][j] = n;
                        n--;
                    }
                }
                OutArr(a, k);
                Console.WriteLine("Для выхода нажмите Esc, иначе - другую кнопку");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
