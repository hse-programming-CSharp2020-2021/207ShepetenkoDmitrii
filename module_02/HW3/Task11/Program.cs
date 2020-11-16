using System;

namespace Task11
{
    class GeaometricProgression
    {
        double _start;
        double _increment;
        public GeaometricProgression()
        {
            _start = 0;
            _increment = 1;
        }
        public GeaometricProgression(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }
        public double this[int index]
        {
            get
            {
                return _start * Math.Pow(_increment, index - 1);
            }
        }
        public string GetInfo()
        {
            return $"первый элемент прогрессии = {_start}  знаменатель прогрессии = {_increment} ";
        }
        public double GetSum(int n)
        {
            double sum = 0;
            for (int i = 1; i < n; i++)
                sum += this[i];
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GeaometricProgression[] a;
            GeaometricProgression b = new GeaometricProgression(2, 2);
            Console.WriteLine("Отдеьная прогрессия: "+b.GetInfo());
            Random r = new Random();
            do
            {
                Console.Clear();
                a = new GeaometricProgression[r.Next(5, 16)];
                for(int i = 0; i < a.Length; i++)
                {
                    a[i] = new GeaometricProgression(r.Next(0, 11), r.Next(1, 5));
                    Console.WriteLine($"{i+1} элемент : {a[i].GetInfo()}");
                }
                int step = r.Next(3, 16);
                foreach(var z in a)
                {
                    Console.WriteLine(z.GetSum(step));
                }
                Console.WriteLine($"{step} элемент отдельной прогрессии = {b[step]}");
                foreach(var z in a)
                {
                    if (z[step] > b[step])
                    {
                        Console.WriteLine(z.GetInfo());
                    }
                }
                Console.WriteLine("Нажмите Esc, чтобы закрыть пррограмму..");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
