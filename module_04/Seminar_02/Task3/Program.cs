using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task3
{
    [Serializable]
    [DataContract]
    public struct ConsoleSymbolStruct
    {
        [DataMember]
        public char simb;
        [DataMember]
        public int x;
        [DataMember]
        public int y;
        public ConsoleSymbolStruct(char simb, int x, int y)
        {
            this.simb = simb;
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{simb} {x} {y}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            ConsoleSymbolStruct[] csc = new ConsoleSymbolStruct[15];
            for (int i = 0; i < 15; i++)
                csc[i] = new ConsoleSymbolStruct((char)r.Next(1,100), r.Next(1,100),r.Next(1,100));
            ConsoleSymbolStruct[] csc1;
            ConsoleSymbolStruct[] csc2;
            ConsoleSymbolStruct[] csc3;
            ConsoleSymbolStruct[] csc4;
            BinaryFormatter bf = new BinaryFormatter();
            using(FileStream f = new FileStream("file.bin", FileMode.Create))
            {
                bf.Serialize(f, csc);
            }
            using (FileStream f = new FileStream("file.bin", FileMode.Open))
            {
                csc1 = (ConsoleSymbolStruct[])bf.Deserialize(f);
            }
            XmlSerializer xs = new XmlSerializer(typeof(ConsoleSymbolStruct[]));
            using (FileStream f = new FileStream("file.xml", FileMode.Create))
            {
                xs.Serialize(f, csc);
            }
            using (FileStream f = new FileStream("file.xml", FileMode.Open))
            {
                csc2 = (ConsoleSymbolStruct[])xs.Deserialize(f);
            }
            using(FileStream fs = new FileStream("csc.json", FileMode.Create))
            using (StreamWriter sw =new StreamWriter(fs))
            {
                sw.Write(JsonSerializer.Serialize(csc));
            }

            using (FileStream fs = new FileStream("csc.json", FileMode.Open))
            using (StreamReader sw = new StreamReader(fs))
            {
                csc3=JsonSerializer.Deserialize<ConsoleSymbolStruct[]>(sw.ReadToEnd());
            }
            
            DataContractSerializer ds = new DataContractSerializer(typeof(ConsoleSymbolStruct[]));
            using (FileStream f = new FileStream("file.txt", FileMode.Create))
            {
                ds.WriteObject(f,csc);
            }
            using (FileStream f = new FileStream("file.txt", FileMode.Open))
            {
                csc4 = (ConsoleSymbolStruct[])ds.ReadObject(f);
            }
            for (int i = 0; i < 15; i++)
                Console.WriteLine($"{csc1[i]}\t\t{csc2[i]}\t\t{csc3[i]}\t\t{csc4[i]}");
        }
    }
}
