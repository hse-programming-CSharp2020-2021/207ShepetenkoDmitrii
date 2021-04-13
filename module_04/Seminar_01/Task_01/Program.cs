using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


/*
Класс Student (студент) включает фамилию и номер курса.В основной программе сосздать массив из n студентов,
сохранить в файл и восстановить из файла. Использовать сериализацию.
 */

/*
Сериализацию можно представить как процесс сохранения состояния объекта в среду хранения. 
Во время этого процесса открытые и закрытые поля объекта и имя класса, включая сборку с классом, 
преобразуются в поток байтов, который затем записывается в поток данных. После десериализации 
объекта создается точная копия исходного объекта. 
https://docs.microsoft.com/ru-ru/dotnet/standard/serialization/binary-serialization
https://docs.microsoft.com/ru-ru/dotnet/standard/serialization/basic-serialization
*/

namespace Task_01
{
    [Serializable]
    public  class Student
    {
        public string Surname { get; set; }
        public int Group { get; set; }
        public Student(string surname, int group)
        {
            Surname = surname;
            Group = group;
        }
        public override string ToString()
        {
            return $"Group {Group}  Surname:{Surname}";
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(1, 10);
            Student[] students = new Student[n];
            for(int i = 0; i < n; i++)
            {
                students[i] = new Student(r.Next(10000, 100000).ToString(), r.Next(1,15));
            }
            foreach (Student student in students)
                Console.WriteLine(student);
            Console.WriteLine();
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("students.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, students);
            stream.Close();

            BinaryFormatter formatter1 = new BinaryFormatter();
            Stream stream1 = new FileStream("students.bin", FileMode.Open, FileAccess.Read);
            Student[] students1 = (Student[])formatter1.Deserialize(stream1);
            stream1.Close();

            foreach (Student student in students1)
                Console.WriteLine(student);
            Console.ReadKey();
        }
    }
}