using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataBaseTask2
{
    [DataContract]
    class Sale : IEntity
    {
        [DataMember]
        public long Id { get; }

        [DataMember]
        public long BuyerId { get; }

        [DataMember]
        public long ShopId { get; }

        [DataMember]
        public long GoodId { get; }

        [DataMember]
        public int Amount { get; }

        [DataMember]
        public int Price { get; }

        public Sale(long id, long buyerId, long shopId, long goodId, int amount, int price)
        {
            Id = id;
            BuyerId = buyerId;
            ShopId = shopId;
            GoodId = goodId;
            Amount = amount;
            Price = price;
        }
    }
}
