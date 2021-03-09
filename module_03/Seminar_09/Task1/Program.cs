using System;
using System.Collections.Generic;
using System.IO;

public class ColorPoint
{
    public static string[] colors = { "Red", "Green", "DarkRed", "Magenta", "DarkSeaGreen", "Lime", "Purple", "DarkGreen", "DarkOrange", "Black", "BlueViolet", "Crimson", "Gray", "Brown", "CadetBlue" };
    public double x, y;
    public string color;
    public override string ToString()
    {
        string format = "{0:F3}    {1:F3}    {2}";
        return string.Format(format, x, y, color);
    }
}

class Test
{
    static Random gen = new Random();
    public static void Main()
    {
        string path = @"..\..\..\..\MyTest.txt";
        int N; // Количество создаваемых объектов (число строк в файле)
               //  TODO: Определить значение N 
        N = int.Parse(Console.ReadLine());
        List<ColorPoint> list = new List<ColorPoint>();
        ColorPoint one;
        for (int i = 0; i < N; i++)
        {
            one = new ColorPoint();
            one.x = gen.NextDouble();
            one.y = gen.NextDouble();
            int j = gen.Next(0, ColorPoint.colors.Length);
            one.color = ColorPoint.colors[j];
            list.Add(one);
        }
        string[] arrData = Array.ConvertAll(list.ToArray(),
                     (ColorPoint cp) => cp.ToString());
        // Запись массива стpок в текстовый файл:         
       using(BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
        {
            foreach(ColorPoint cp in list)
            {
                bw.Write(cp.color);
                bw.Write(cp.x);
                bw.Write(cp.y);
            }
        }
        Console.WriteLine("Записаны {0} строк в текстовый файл: \n{1}",
                                                                  N, path);
    }
} // class Test