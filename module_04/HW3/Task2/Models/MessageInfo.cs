using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class MessageInfo
    {
        public int Id { get; set; }

        public int RecieverId { get; set; }

        public int SenderId { get; set; }

        public string Message { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
