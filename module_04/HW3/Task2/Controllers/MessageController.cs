using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.Controllers
{
    public class MessageController : Controller
    {
        private Storage _storage;

        public MessageController(Storage storage) 
        {
            _storage = storage; 
        }

        public static List<MessageInfo> messages = new List<MessageInfo>();

        [HttpPost("send-message")]
        public IActionResult SendMessage([FromBody] SendMessageRequest req)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_storage.users.Exists(x => x.Id == req.SenderId) == false) 
            {
                return NotFound(new { Message = $"Пользователь-отправитель senderId = {req.SenderId} не найден" });
            }

            if (_storage.users.Exists(x => x.Id == req.RecieverId) == false)
            {
                return NotFound(new { Message = $"Пользователь-получатель recieverId = {req.RecieverId} не найден" });
            }

            var message = new MessageInfo()
            {
                Id = messages.Count + 1,

                RecieverId = req.RecieverId,

                SenderId = req.SenderId,

                Message = req.Message,

                Timestamp = DateTime.Now
            };
            messages.Add(message);
            return Ok(message);
        }



        [HttpGet("get-messages")]
        public IActionResult GetMessagesBySenderAndReceiver([FromQuery] int senderId, int receiverId)
        {
            var result = messages.Where(x => x.RecieverId == receiverId && x.SenderId == senderId).ToList();
            if (result.Count == 0)
            {
                return NotFound(new { Message = $"Сообщений от пользователя с Id = {senderId} к пользователю с Id = {receiverId} не найдено" });
            }
            return Ok(result);
        }


    }
}
