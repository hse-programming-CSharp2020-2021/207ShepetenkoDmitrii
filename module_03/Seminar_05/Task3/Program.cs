using System;
using System.Collections.Generic;


/// <summary>
/// Пассажир
/// </summary>
public class Passenger
{
    public Passenger(string name, string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }
    string name;
    string lastName;
    int age;
    public bool IsOld { private set; get; }
    public string Name
    {
        set
        { // only latin simbols and spaces
          // not longer 30 simbols 
            if (value.Length > 30)
                throw new ArgumentException("not longer 30 simbols");
            
            name = value;
        }
        get
        {
            return name;
        }
    }
    public string LastName
    {
        set
        { // only latin simbols and spaces
          // not longer 40 simbols 
            if (value.Length > 40)
                throw new ArgumentException("not longer 40 simbols");

            lastName = value;
        }
        get
        {
            return name;
        }
    }
    public int Age
    {
        set
        { // more then 0
            if(value<=0)
                throw new ArgumentException("more then 0");
            age = value;
        }
        get { return age; }
    }
    public override string ToString()
    {
        string s = "";
        if (IsOld)
            s = " OLD";
        return $"Name: {Name}\tLastName: {LastName}\tAge: {Age}"+s;
    }
}
/// <summary>
/// Пассажир с детьми
/// </summary>
public class PassengerWithChildren : Passenger
{
    public PassengerWithChildren(int n, bool usl, string Name, string lastName,int age) :base(Name, lastName, age)
    {
        NumberOfChildren = n;
        IsNewBorn = usl;
    }
    int numberOfChildren;
    public bool IsNewBorn { private set; get; }
    public int NumberOfChildren
    {
        set
        { // strictly more then 0
            if(value<=0)
                throw new ArgumentException("more then 0");
            numberOfChildren = value;
        }
        get { return numberOfChildren; }     
    }

    public override string ToString()
    {
        string s = "";
        if (IsNewBorn)
            s = " with newborn";
        return $"Name: {Name}\tLastName: {LastName}\tAge: {Age}  with children({NumberOfChildren})" + s;
    }
}
/// <summary>
/// Очередь на посадку состоит из двух подочередей: обычной и приоритетной
/// Пассажиры приоритетной очереди обслуживаются вне очереди
/// </summary>
public class PassengerQueue
{
    // if passenger is ordinary we use ordinaryQueue
    Queue<Passenger> ordinaryQueue = new Queue<Passenger>();
    // if passenger is old or with newborns we use priorityQueue
    Queue<Passenger> priorityQueue = new Queue<Passenger>();

    public void AddToQueue(Passenger newPassenger)
    {
        if (newPassenger.Age > 65 || newPassenger is PassengerWithChildren && ((PassengerWithChildren)newPassenger).IsNewBorn) priorityQueue.Enqueue(newPassenger);
        else ordinaryQueue.Enqueue(newPassenger);
    }
    public void StartServingQueue()
    {
        int usl = 1;
        if((priorityQueue.Count>0)&(priorityQueue.Count<=3))
        {
            Passenger p = priorityQueue.Dequeue();
            Console.WriteLine($"Priority: {p}");
        }
        while (priorityQueue.Count > 0 & ordinaryQueue.Count > 0)
        {
            if ((priorityQueue.Count > 0) & (usl == 1))
            {
                Passenger p = priorityQueue.Dequeue();
                Console.WriteLine($"Priority: {p}");
            }
            else
            {
                Passenger p = ordinaryQueue.Dequeue();
                Console.WriteLine($"Ordinary: {p}");
            }
            usl *= -1;
        }
        if (priorityQueue.Count > 0)
        {
            while (priorityQueue.Count > 0)
            {
                Passenger p = priorityQueue.Dequeue();
                Console.WriteLine($"Priority: {p}");
            }
        }
        if (ordinaryQueue.Count > 0)
        {
            while (ordinaryQueue.Count > 0)
            {
                Passenger p = ordinaryQueue.Dequeue();
                Console.WriteLine($"Ordinary: {p}");
            }
        }
    }
}

class MainClass
{
    public static void Main()
    {
        Random r = new Random();
        int n = r.Next(1, 20);
        PassengerQueue q = new PassengerQueue();
        for(int i = 0; i < n; i++)
        {
            Passenger p;
            if (r.Next(0, 2) == 1)
                p = new Passenger(r.Next(1000, 10000).ToString(), r.Next(1000, 10000).ToString(), r.Next(16, 90));
            else
                p = new PassengerWithChildren(r.Next(1, 6), Convert.ToBoolean(r.Next(0, 2)), r.Next(1000, 10000).ToString(), r.Next(1000, 10000).ToString(), r.Next(16, 90));
            q.AddToQueue(p);
        }
        q.StartServingQueue();
    }
}
