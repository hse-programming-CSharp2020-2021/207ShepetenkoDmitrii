using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    [DataContract]
    class Shop : IEntity
    {
        [DataMember]
        public long Id { get; }

        [DataMember]
        public string Name { get; }

        [DataMember]
        public string City { get; }

        [DataMember]
        public string District { get; }

        [DataMember]
        public string Country { get; }

        [DataMember]
        public long Phone { get; }        

        public Shop(long id, string name, string city, string district, string country, long phone)
        {
            Id = id;
            Name = name;
            City = city;
            District = district;
            Country = country;
            Phone = phone;
        }
    }
}