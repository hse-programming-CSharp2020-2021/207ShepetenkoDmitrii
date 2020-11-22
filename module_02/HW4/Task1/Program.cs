using System;

namespace Task1
{
    class A
    {
        int a;
        public A()
        {
            a = 5;
        }
        public virtual void getA()
        {
            Console.WriteLine(a);
        }
    }
    class B : A
    {
        int b;
        public B()
        {
            b = 4;
        }
        public override void getA()
        {
            Console.WriteLine(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            A[] a = new A[10];
            Console.WriteLine("Все переменные:");
            for(int i = 0; i < 10; i++)
            {
                a[i] = r.Next(0, 2) == 1 ? new A() : new B();
            }
            foreach (var z in a)
                z.getA();
            Console.WriteLine("Переменные класса А:");
            foreach (A z in a)
                if(!(z is B))
                    z.getA();
            Console.WriteLine("Переменные класса В:");
            foreach (A z in a)
                if(z is B)
                    z.getA();
        }
    }
}
