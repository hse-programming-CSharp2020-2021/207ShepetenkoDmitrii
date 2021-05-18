using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataBaseTask2
{
    [DataContract]
    class Buyer : IEntity
    {
        [DataMember]
        public long Id { get; }

        [DataMember]
        public string FirstName { get; }

        [DataMember]
        public string LastName { get; }

        [DataMember]
        public string Adress { get; }

        [DataMember]
        public string City { get; }

        [DataMember]
        public string District { get; }

        [DataMember]
        public string Country { get; }
        
        [DataMember]
        public int Index { get; }

        public Buyer(long id, string firstname, string lastname, string adress, string city, string district,
            string country, int index)
        {
            this.Adress = adress;
            this.City = city;
            this.Country = country;
            this.District = district;
            this.FirstName = firstname;
            this.Id = id;
            this.Index = index;
            this.LastName = lastname;
        }
    }
}
