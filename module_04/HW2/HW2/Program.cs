using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace DataBaseTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase("ShopDataBase");

            db.CreateTable<Good>();
            db.CreateTable<Shop>();

            db.InsertInto<Shop>(new ShopFactory("Auchan", "Msk", "Centr", "Russia", 11111));
            db.InsertInto<Shop>(new ShopFactory("Magnit", "Voronezh", "Centr", "Russia", 2221));

            db.InsertInto<Good>(new GoodFactory("Pepsi", 1, "voda", "tasty"));
            db.InsertInto(new GoodFactory("3 korochki", 1,"eda", "nu takoe"));
            db.InsertInto(new GoodFactory("Ohota", 2, "eda", "?"));
            db.InsertInto(new GoodFactory("Lays", 3, "eda", "chipsiii"));

            var auchanId = (from shop in db.Table<Shop>()
                            where shop.Name == "Auchan"
                            select shop.Id).First();

            var allAuchanGoods = from good in db.Table<Good>()
                                 where good.ShopId == auchanId
                                 select good.Name;

            foreach (var goodName in allAuchanGoods)
            {
                Console.WriteLine(goodName);
            }

            Console.ReadKey();
            var stream = new FileStream("data.json",  FileMode.OpenOrCreate);
            var ser = new DataContractJsonSerializer(typeof(DataBase), new []{typeof(int), typeof(string),typeof(long), typeof(Good),typeof(Sale), typeof(Shop), typeof(Buyer), typeof(IEnumerable<Shop>), typeof(IEnumerable<Buyer>), typeof(IEnumerable<Good>), typeof(IEnumerable<Sale>)});
            ser.WriteObject(stream, db.Table<Shop>());
            stream.Position = 0;
            var sr = new StreamReader(stream);
            Console.Write("JSON form of Person object: ");
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}