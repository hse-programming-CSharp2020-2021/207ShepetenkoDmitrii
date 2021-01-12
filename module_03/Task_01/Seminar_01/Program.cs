using System;

namespace Task1
{
    class Program
    {
        public delegate int[] D1(int a);
        public delegate void D2(int[] a);
        public static int[] Method1(int a)
        {
            int[] arr = new int[0];
            while (a > 0)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = a % 10;
                a /= 10;                
            }
            Array.Reverse(arr);
            return arr;
        }
        public static void Method2(int[]arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
        static void Main(string[] args)
        {
            D1 d = Method1;
            D2 dd = Method2;
            int[] z = d?.Invoke(56789);
            dd(z);
            Console.WriteLine($"\nd.Target = {d.Target}");
            Console.WriteLine($"d.Method = {d.Method}");
        }
    }
}
