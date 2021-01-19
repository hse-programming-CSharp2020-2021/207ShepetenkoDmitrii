using System;

namespace Task1
{
    class Plant
    {
        double growth;
        double photosensitivity;
        double frostresistance;
        public Plant(double g, double p, double f)
        {
            if (g < 0)
                throw new ArgumentException();
            if ((p < 0) || (p > 100))
                throw new ArgumentException();
            if ((f < 0) || (f > 100))
                throw new ArgumentException();
            growth = g;
            photosensitivity = p;
            frostresistance = f;
        }
        public double GrowthInfo
        {
            get
            {
                return growth;
            }
        }
        public double PhotosensitivityInfo
        {
            get
            {
                return photosensitivity;
            }
        }
        public double FrostresistanceInfo
        {
            get
            {
                return frostresistance;
            }
            set
            {
                frostresistance=value;
            }
        }
        public override string ToString()
        {
            return $"Growth = {growth}\tPhotosensitivity = {photosensitivity}\tFrostresistance = {frostresistance}";
        }
    }
    class Program
    {
        static int Fun(Plant a, Plant b)
        {
            if ((int)a.FrostresistanceInfo % 2 == 0) return -1;
            return 0;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out n));
            Plant[] plants = new Plant[n];
            for (int i = 0; i < n; i++)
                plants[i] = new Plant(rnd.Next(25, 100) + rnd.NextDouble(), rnd.Next(100) + rnd.NextDouble(), rnd.Next(100) + rnd.NextDouble());
            Action<Plant> a = p => Console.WriteLine(p.ToString());
            Comparison<Plant> c1 = delegate(Plant a,Plant b) 
            {
                if (a.GrowthInfo > b.GrowthInfo) return -1;
                if (a.GrowthInfo < b.GrowthInfo) return 1;
                return 0;
            };
            Comparison<Plant> c2 = (a, b) =>
            {
                if (a.PhotosensitivityInfo > b.PhotosensitivityInfo) return 1;
                if (a.PhotosensitivityInfo < b.PhotosensitivityInfo) return -1;
                return 0;
            };
            Comparison<Plant> c3 = Fun;
            Array.ForEach(plants, a);
            Array.Sort(plants, c1);
            Console.WriteLine();
            Array.ForEach(plants, a);
            Array.Sort(plants, c2);
            Console.WriteLine();
            Array.ForEach(plants, a);
            Array.Sort(plants, c3);
            Console.WriteLine();
            Array.ForEach(plants, a);
            Converter<Plant, Plant> a0 = p =>
            {
                if ((int)p.FrostresistanceInfo % 2 == 0) p.FrostresistanceInfo /= 3;
                else p.FrostresistanceInfo /= 2;
                return p;
            };
            Plant[] p =Array.ConvertAll(plants, a0);
            Console.WriteLine();
            Array.ForEach(p, a);
        }
    }
}
