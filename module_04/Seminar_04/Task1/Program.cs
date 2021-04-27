using System;
using System.Collections;

class Fibbonacci
{
    int curr = 0;

    int prev = 1;

    public IEnumerable nextMemb(uint k)
    {
        curr = 0;
        prev = 1;

        for(int i = 0; i < k; i++)
        {
            curr += prev;
            prev = curr - prev;
            yield return curr;
        }        
    }
}

class TriangleNums
{
    public IEnumerable nextMemb(uint k)
    {
        for (int i = 0; i < k; i++)
            yield return 0.5 * i * (i + 1);
    }
}

class Program
{
    static void Main()
    {

        Fibbonacci fi = new Fibbonacci();

        TriangleNums tri = new TriangleNums();

        foreach (int numb in fi.nextMemb(7))

            Console.Write(numb + "  ");

        Console.WriteLine();

        foreach (double numb in tri.nextMemb(7))

            Console.Write(numb + "  ");

        Console.WriteLine();

        var fifi = fi.nextMemb(7).GetEnumerator();
        var tritri = tri.nextMemb(7).GetEnumerator();
        for(int i = 0; i < 7; i++)
        {
            fifi.MoveNext();
            tritri.MoveNext();
            Console.Write((int)fifi.Current+(double)tritri.Current + "  " );            
        }

    }
}