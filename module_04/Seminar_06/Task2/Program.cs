
//С помощью средств LINQ выделить только млекопитающих (объектов класса Mammal), у которых нет опекуна.
// Вывести на экран информацию об объектах из выделенной последовательности.



using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{

    interface IVocal
    {
        void DoSound();
    }

    abstract class Animal : IVocal
    {        

        protected static int curid = 1;

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsTakenCare { get; set; }

        public virtual void DoSound()
        {
        }

        public override string ToString()
        {
            return $"ID: {Id};  Name: {Name};  Is Taken Care: {IsTakenCare}";
        }       
    }

    class Mammal : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("я млекопитающие, би-би-би");
        }

        public int Paws { get; }

        public Mammal(string name, bool isTakencare, int paws)
        {
            Id = curid++;
            Name = name;
            IsTakenCare = isTakencare;
            if (paws < 1 || paws > 20)
                throw new ArgumentException("Неверное количество лап");
            Paws = paws;
        }

        public override string ToString()
        {
            return base.ToString() + $";  Paws: {Paws}";
        }
    }


    class Bird : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("я птичка, пип-пип-пип");
        }

        private int speed;
        public int Speed
        {
            get => speed;
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentException("странная скорость");
                speed = value;
            }
        }

        public Bird(string name, bool isTakenCare, int speed)
        {
            Id = curid++;
            Name = name;
            IsTakenCare = isTakenCare;
            Speed = speed;
        }

        public override string ToString()
        {
            return base.ToString() + $"   Speed: {Speed}";
        }
    }

    class Zoo
    {
        public List<Animal> Animals { get; set; }

        public Zoo(List<Animal> animals)
        {
            Animals = animals;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            List<Animal> animals = new List<Animal>();
            Animal animal;
            for(int i = 0; i < n; i++)
            {
                if(r.NextDouble()>0.5)                
                    animal = new Mammal(r.Next(1000).ToString(), r.NextDouble()>0.5,r.Next(1,20));
                else
                    animal = new Bird(r.Next(1000).ToString(), r.NextDouble() > 0.5, r.Next(1, 100));
                animals.Add(animal);
            }
            Zoo zoo = new Zoo(animals);
            foreach (Animal a in zoo.Animals)
                Console.WriteLine(a);
            Console.WriteLine();
            var birdsWithCare = zoo.Animals.Where(x => x.GetType() == typeof(Bird) && x.IsTakenCare);
            foreach (var i in birdsWithCare)
                Console.WriteLine(i);
            Console.WriteLine();
            var mammalsWithoutCare = zoo.Animals.Where(x => x.GetType() != typeof(Bird) && !x.IsTakenCare);
            foreach (var o in mammalsWithoutCare)
                Console.WriteLine(o);

        }
    }
}
