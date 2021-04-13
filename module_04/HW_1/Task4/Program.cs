using System;
using System.IO;
using System.Xml.Serialization;

namespace Task4
{
    [Serializable]
    public class Multiple
    {
        public  string name;
        public  int divisor;
        public  int[] numbers;
        public override string ToString()
        {
            string mom = "Делитель: " + divisor + " - " + name + "\r\nКратные: ";
            foreach (int m in numbers)
                mom += m + "  ";
            return mom;
        }

        public Multiple() { }
        public Multiple(int div, int[] ar)
        {
            if (div <= 0 || div > 9)
                throw new Exception("Неверно выбран делитель!");
            divisor = div;
            switch (div)
            {
                case 1: name = "один"; break;
                case 2: name = "два"; break;
                case 3: name = "три"; break;
                case 4: name = "четыре"; break;
                case 5: name = "пять"; break;
                case 6: name = "шесть"; break;
                case 7: name = "семь"; break;
                case 8: name = "восемь"; break;
                case 9: name = "девять"; break;
            }
            int[] temp = new int[ar.Length];
            int numb = 0;
            for (int i = 0; i < ar.Length; i++)
                if (ar[i] % div == 0) temp[numb++] = ar[i];
            numbers = new int[numb];
            Array.Copy(temp, numbers, numb);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Multiple row;
            int size = 0;
            do
                Console.Write("Введите размер генеральной совокупности: ");
            while (!int.TryParse(Console.ReadLine(), out size) | size < 1);
            Random gen = new Random(5);
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = gen.Next(0, 100);
                Console.Write(data[i] + "  ");
            }
            Console.WriteLine();
            XmlSerializer serializer = new XmlSerializer(typeof(Multiple), new Type[] { typeof(int[]), typeof(int), typeof(string) });
            using (FileStream fs = new FileStream("data.xml",
                                      FileMode.Create))
            {
                do
                {
                    int div;
                    do
                    {
                        do Console.Write("Введите делитель: ");
                        while (!int.TryParse(Console.ReadLine(), out div));
                        try
                        {
                            row = new Multiple(div, data);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Нужен делитель от 1 до 9!");
                            continue;
                        }
                    }
                    while (true);
                    serializer.Serialize(fs, row);
                    Console.WriteLine("\nДля чтения файла - клавиша ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            using (FileStream fs = new FileStream("data.xml",
                                     FileMode.Open))
            {
                while (true)
                    try
                    {
                        row = (Multiple)serializer.Deserialize(fs);
                        Console.WriteLine(row.ToString());
                    }
                    catch
                    {
                        break;
                    }
            }
        }
    }
}
