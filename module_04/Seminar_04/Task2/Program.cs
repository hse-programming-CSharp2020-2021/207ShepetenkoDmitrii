using System;
using System.Collections;

class RandomCollection : IEnumerable
{
    int len { get; }
    

    public RandomCollection(int n)
    {
        len = n;
    }
    
    public IEnumerator GetEnumerator()
    {
        return new RandomEnumerator(len);
    }

    private class RandomEnumerator : IEnumerator
    {
        int n;

        int pos = 0;

        Random r = new Random();

        public RandomEnumerator(int n)
        {
            this.n = n;
        }

        public object Current => r.Next();

        public bool MoveNext()
        {
            return ++pos < n;
        }

        public void Reset()
        {
            pos = 0;
        }
    }
}

class Program
{
    static void Main()
    {
        RandomCollection r = new RandomCollection(15);
        foreach (int i in r)
            Console.Write($"{i} ");
        Console.WriteLine();
        foreach (int i in r)
            Console.Write($"{i} ");
    }
}