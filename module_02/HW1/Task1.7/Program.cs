using System;
using System.Linq;

namespace Task1._7
{
    class Program
    {
        public static string[] Fil = { "Западный", "Центральный", "Восточный" };
        public static string[] Kva = { "Первый", "Второй", "Третий", "Четвертый" };
        public static void F1(int[,]a)
        {
            int s = 0;
            foreach (int z in a)
                s += z;
            Console.WriteLine("Всего продано: "+s);
        }
        public static void F2(int[,]a)
        {
            int n;
            do
            {
                Console.WriteLine("1 - Западный\n2 - Центральный\n3 - Восточный");
            } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1) | (n > 3));
            int max = 0;
            int maxi = 0;
            for(int i=0;i<4;i++)
            {
                if(a[i,n-1]>max)
                {
                    max = a[i, n - 1];
                    maxi = i;
                }
            }
            Console.WriteLine("За " + Kva[maxi] + " квартал "+Fil[n-1]+" филиал продал максимальное количество автомобилей: "+max);
        }
        public static void F3(int[,]a)
        {
            int[] max = new int[3];
            for (int i=0;i<3;i++)
            {
                for(int j=0;j<4;j++)
                {
                    max[i] += a[j, i];
                }
            }
            int m = max.Max();
            for(int i=0;i<max.Length;i++)
            {
                if (max[i]==m)
                {
                    Console.WriteLine(Fil[i]+" филиал продал большего всего автомобилей за все кварталы: "+max[i]);
                }
            }
        }
        public static void F4(int[,] a)
        {
            int[] max = new int[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    max[i] += a[i, j];
                }
            }
            int m = max.Max();
            for (int i = 0; i < max.Length; i++)
            {
                if (max[i] == m)
                {
                    Console.WriteLine("За "+Kva[i] + " квартал продал большего всего автомобилей: " + max[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            do
            {
                int[,] a = { { 20, 24, 25 }, { 21, 20, 18 }, { 23, 27, 24 }, { 22, 19, 20 } };
                int n;
                do
                {
                    Console.WriteLine("\n1.Подсчитать общее количество автомобилей, проданных всеми филиалами компании за год.\n" +
                        "2.Вывести максимальное количество автомобилей, проданных филиалом за квартал, а также название филиала и номер квартала.\n" +
                        "3.Вывести название филиала, который продал максимальное количество автомобилей по результатам года, а также проданное филиалом количество автомобилей\n" +
                        "4.Вывести наиболее успешный квартал, в котором компания показала наилучший результат по продажам , а также количество автомобилей проданное в нем.\n" +
                        "Выберите пункт: ");
                } while (!int.TryParse(Console.ReadLine(), out n) | (n < 1) | (n > 4));
                switch (n)
                {
                    case 1:
                        F1(a);
                        break;
                    case 2:
                        F2(a);
                        break;
                    case 3:
                        F3(a);
                        break;
                    case 4:
                        F4(a);
                        break;
                }
                Console.WriteLine("Для выхода из программы нажмите Esc");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
    }
}
