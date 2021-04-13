using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization;

namespace Task2
{
    [DataContract]
    public class Human
    {
        [DataMember]
        public string Name { get; set; }        

        public Human(string name)
        {

            this.Name = name;

        }
    }

    [DataContract]
    public class Professor : Human
    {
        public Professor(string name) : base(name) { }        
    }

    [DataContract]
    public class Dept
    {
        [DataMember]
        public string DeptName { get; set; }
        [DataMember]
        public List<Human> staff;

        public List<Human> Staff { get { return staff; } }

        

        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            staff = new List<Human>(staffList);
        }
    }

    [DataContract]
    public class University
    {
        [DataMember]
        public string UniversityName { get; set; }
        [DataMember]
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
            DataContractSerializer ds = new DataContractSerializer(typeof(University), new Type[] { typeof(Professor), typeof(Dept), typeof(Human)});
            University Hse;
            using(FileStream fs = new FileStream("f.txt", FileMode.Create))
            {
                ds.WriteObject(fs,HeSeEe);
            }
            using (FileStream fs = new FileStream("f.txt", FileMode.Open))
            {
                Hse=(University)ds.ReadObject(fs);
            }
            Console.WriteLine(Hse.UniversityName);
            foreach (Dept d in Hse.Departments)
                Console.WriteLine(d.DeptName);
        }
    }
}
