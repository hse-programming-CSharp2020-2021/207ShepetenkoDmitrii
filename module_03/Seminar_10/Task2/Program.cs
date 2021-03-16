using System;
using System.IO;
class Program
{
    static void Main()
    {
        BinaryWriter fOut = new BinaryWriter(
           new FileStream("../../../t.dat", FileMode.Create));
        for (int i = 0; i <= 10; i += 2)
            fOut.Write(i);
        fOut.Close();
        FileStream f = new FileStream("../../../t.dat", FileMode.Open);
        BinaryReader fIn = new BinaryReader(f);
        long n = f.Length / 4;
        int a;
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            Console.Write(a + " ");
        }
        Console.WriteLine("\nЧисла в обратном порядке:");        
        // 1) TODO: Прочитать и напечатать все числа из файла в обратном порядке
        for (int i = 1; i <= n; i++)
        {
            f.Position=4*(n-i);            
            a = fIn.ReadInt32();
            Console.Write(a + " ");
        }
        // 2) TODO: увеличить  все числа в файле в 5 раз
        BinaryWriter fO = new BinaryWriter(f);
        f.Position = 0;
        for(int i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            f.Position -= 4;
            fO.Write(a * 5);
        }
        // 3) TODO: Прочитать и напечатать все числа из файла в прямом порядке
        f.Position = 0;
        Console.WriteLine("\nУвеличенные числа:");
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            Console.Write(a + " ");
        }
        fIn.Close();
        f.Close();
    }
}