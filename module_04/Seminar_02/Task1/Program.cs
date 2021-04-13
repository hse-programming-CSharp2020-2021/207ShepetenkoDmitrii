using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace Task1
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }

        public Human() { }

        public Human(string name)
        {

            this.Name = name;

        }
    }

    [Serializable]
    public class Professor : Human
    {
        public Professor(string name) : base(name) { }
        public Professor() { }
    }

    [Serializable]
    public class Dept
    {
        public string DeptName { get; set; }

        public List<Human> staff;

        public List<Human> Staff { get { return staff; } }

        public Dept() { }

        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            staff = new List<Human>(staffList);
        }
    }

    [Serializable]
    public class University
    {
        public string UniversityName { get; set; }

        public List<Dept> Departments { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            University HeSeEe = new University();
            HeSeEe.UniversityName = "ХСЕ";
            Human[] professors = { new Professor("Best"), new Professor("BestBest") };
            Dept dept = new Dept("ПИ", professors);
            HeSeEe.Departments = new List<Dept>();
            HeSeEe.Departments.Add(dept);
            string hse = JsonSerializer.Serialize<University>(HeSeEe);
            University Hse;
            Hse = JsonSerializer.Deserialize<University>(hse);
            Console.WriteLine(Hse.UniversityName);
            foreach (Dept d in Hse.Departments)
                Console.WriteLine(d.DeptName);
        }
    }
}
