using System;
using System.Collections.Generic;

namespace Task2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Age}";
        }
    }
    class ElectronicQueue
    {
        public Queue<Person> queue;
        public ElectronicQueue()
        {
            queue = new Queue<Person>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ElectronicQueue eq = new ElectronicQueue();
            eq.queue.Enqueue(new Person("A", "B", 21));
            eq.queue.Enqueue(new Person("C", "Q", 1));
            eq.queue.Enqueue(new Person("A", "BBBBBBBBBBBBBBBB", 231));
            eq.queue.Dequeue();
            foreach (Person person in eq.queue)
                Console.WriteLine(person);
        }
    }
}
