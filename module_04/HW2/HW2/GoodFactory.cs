using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    class GoodFactory : IEntityFactory<Good>
    {
        private static long _id = 0;

        private string _name;

        private long _shopId;

        private string _category;

        private string _description;

        public GoodFactory(string name, long shopId, string category, string description)
        {
            _name = name;
            _shopId = shopId;
            _category = category;
            _description = description;
        }

        public Good Instance => new Good(_id++, _name, _shopId,_category, _description);
    }
}