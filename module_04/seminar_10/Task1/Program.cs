using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class LucassCollection : IEnumerable<int>
    {
        int n;
        public LucassCollection(int n)
        {
            this.n = n;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new LucassCollectionEnumerator(n);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LucassCollectionEnumerator(n);
        }
    }

    class LucassCollectionEnumerator : IEnumerator<int>
    {
        public int length;


        public LucassCollectionEnumerator(int n)
        {
            length = n;
        }

        int pos = -1;

        int prev2 = 2, prev1 = 1;

        public int Current
        {
            get
            {
                if (pos == 0)
                    return 2;
                if (pos == 1)
                    return 1;
                int t = prev2 + prev1;
                prev2 = prev1;
                prev1 = prev2 + prev1;
                return prev2 + prev1;
            }           
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }


        public bool MoveNext()
        {
            pos++;
            return pos < length;
        }

        public void Reset()
        {
            pos = -1;
            prev1 = 1;
            prev2 = 2;
        }

        public void Dispose()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            foreach (var i in new LucassCollection(n))
                Console.Write($"{i} ");
        }
    }
}
