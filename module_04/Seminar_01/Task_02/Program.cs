using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task_02
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

        List<Human> staff;

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
            XmlSerializer serializer = new XmlSerializer(typeof(University), new Type[] { typeof(Dept), typeof(Professor), typeof(Human)});
            using(FileStream fs = new FileStream("txt.xml", FileMode.Create))
            {
                serializer.Serialize(fs, HeSeEe);
            }
            University Hse;
            using (FileStream fs = new FileStream("txt.xml", FileMode.Open))
            {
                Hse= (University)serializer.Deserialize(fs);
            }             
        }
    }
}
