using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseTask2
{
    class BuyerFactory : IEntityFactory<Buyer>
    {
        private static long _id = 1;

        private string _firstName;

        private string _lastName;

        private string _adress;

        private string _city;

        private string _district;

        private string _country;

        private int _index;

        public BuyerFactory(string firstname, string lastname, string adress, string city, string district,
            string country, int index)
        {
            _adress = adress;
            _city = city;
            _country = country;
            _district = district;
            _firstName = firstname;            
            _index = index;
            _lastName = lastname;
        }

        public Buyer Instance => new Buyer(_id++, _firstName, _lastName, _adress, _city, _district, _country, _index);
    }
}
