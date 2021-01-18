using System;

namespace Task3
{
    class TemperatureConvertImp
    {
        public double fromCToF(double c)
        {
            return (9.0 / 5.0) * c + 32;
        }

        public double fromFToC(double f)
        {
            return (5.0 / 9.0) * (f - 32);
        }
    }
    class StaticTempConverters
    {
        public static double fromCToK(double c)
        {
            return c + 273.15;
        }
        public static double fromKToC(double k)
        {
            return k - 273.15;
        }
        public static double fromCToRe(double c)
        {
            return c * 0.8;
        }
        public static double fromReToC(double re)
        {
            return re * 1.25;
        }
        public static double fromCToRa(double c)
        {
            return c * (9.0 / 5.0) + 491.67;
        }
        public static double fromRaToC(double ra)
        {
            return (ra - 491.67) * (5.0 / 9.0);
        }
    }
    class Program
    {
        delegate double delegateConvertTemperature(double t);
        
        static void Main(string[] args)
        {
            TemperatureConvertImp t = new TemperatureConvertImp();
            delegateConvertTemperature[] d = new delegateConvertTemperature[8];
            d[0] = t.fromCToF;
            d[1] = t.fromFToC;
            d[2] = StaticTempConverters.fromCToK;
            d[3] = StaticTempConverters.fromKToC;
            d[4] = StaticTempConverters.fromCToRa;
            d[5] = StaticTempConverters.fromRaToC;
            d[6] = StaticTempConverters.fromCToRe;
            d[7] = StaticTempConverters.fromReToC;
            double c;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите темпратуру в цельсиях");
                if (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Неверный ввод");
                    Console.WriteLine("Нажмите Esc для завершения...");
                    continue;
                }
                Console.WriteLine($"{d[0](c)} F; {d[2](c)} K; {d[4](c)}Ra; {d[6](c)}Re");
                Console.WriteLine("Нажмите Esc для завершения...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
