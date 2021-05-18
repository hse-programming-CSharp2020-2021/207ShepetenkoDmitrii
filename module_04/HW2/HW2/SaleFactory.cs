using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseTask2
{
    class SaleFactory:IEntityFactory<Sale>
    {

        private static long _id = 1;

        private long _buyerId;

        private long _shopId;

        private long _goodId;

        public int _amount;

        public int _price;

        public Sale Instance => new Sale(_id++, _buyerId, _shopId, _goodId, _amount, _price);

        public SaleFactory(long buyerId, long shopId, long goodId, int amount, int price)
        {            
            _buyerId = buyerId;
            _shopId = shopId;
            _goodId = goodId;
            _amount = amount;
            _price = price;
        }
    }
}
