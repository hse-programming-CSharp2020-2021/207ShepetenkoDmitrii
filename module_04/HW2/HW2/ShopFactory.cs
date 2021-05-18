using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    class ShopFactory : IEntityFactory<Shop>
    {
        private static long _id = 1;

        private string _name;

        private string _city;

        private string _district;

        private string _country;

        private long _phone;

        public ShopFactory(string name, string city, string district, string country, long phone)
        {
            _name = name;
            _city = city;
            _district = district;
            _country = country;
            _phone = phone;
        }

        public Shop Instance => new Shop(_id++, _name, _city, _district, _country, _phone);
    }
}