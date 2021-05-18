using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    [DataContract]
    class Good : IEntity
    {
        [DataMember]
        public long Id { get; }
        
        [DataMember]
        public string Name { get; }

        [DataMember]
        public long ShopId { get; }

        [DataMember]
        public string Category { get; }

        [DataMember]
        public string Description { get; }
        
        public Good(long id, string name, long shopId, string category, string description)
        {
            Id = id;
            Name = name;
            ShopId = shopId;
            Category = category;
            Description = description;
        }
    }
}