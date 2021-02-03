using System;

namespace Task6
{    
    public delegate void MethodsEvents();
    public delegate void ItemEvents(int[,] ar);

    public class Methods
    {
        //  строка заполнена
        public static event MethodsEvents LineComplete;
        
        // новый элемент проинициализирован 
        public static event ItemEvents NewItemFilled;        

        // метод заполнения массива
        public static void ArrayFill(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = rnd.Next(100);
                    NewItemFilled?.Invoke(arr);
                }
        }
        // обработчик события добавления элемента вычисляет сумму элементов
        public static void ArraySumCount(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    sum += arr[i, j];
            }
            Console.WriteLine(sum);
        }

        public static void ArrayAverage(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    sum += arr[i, j];
            }
            double res = sum / (double)(arr.GetUpperBound(0) * arr.GetUpperBound(0));
            Console.WriteLine(res);
        }

        public static void ArrayChangeMax(int[,] arr)
        {
            int max = arr[0,0];
            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    if(arr[i, j] >= max)
                    {
                        max = arr[i, j];
                        ind1 = i;
                        ind2 = j;
                    }
            }
            arr[ind1, ind2] = -2;
        }


        public static void ArrayPrint(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    Console.Write(arr[i, j] + " ");
                LineComplete(); // событие!!
            }
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[15, 15];            
            Methods.LineComplete += () => { Console.WriteLine(); };
            Methods.NewItemFilled += Methods.ArraySumCount;
            Methods.NewItemFilled += Methods.ArrayAverage;
            Methods.NewItemFilled += Methods.ArrayChangeMax;
            Methods.ArrayFill(arr);
            Methods.ArrayPrint(arr);

        }
    }
}
