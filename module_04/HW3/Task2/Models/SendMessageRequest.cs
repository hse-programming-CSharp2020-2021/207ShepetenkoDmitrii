using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class SendMessageRequest
    {
        public int RecieverId { get; set; }

        public int SenderId { get; set; }

        public string Message { get; set; }
    }
}
