using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.Controllers
{
    public class UserController : Controller
    {

        private Storage _storage;
        public UserController(Storage storage)
        {
            _storage = storage; 
        }        

        [HttpPost("create-user")]
        public IActionResult CreateUser([FromBody] CreateUserRequest req)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = new UserInfo()
            {
                Id = _storage.users.Count + 1,
                Email = req.Email,
                UserName = req.UserName
            };
            _storage.users.Add(user);
            return Ok(user);
        }

        [HttpGet("get-user-by-id")]
        public IActionResult GetUserById([FromQuery] int id)
        {
            var result = _storage.users.Where(x => x.Id == id).ToList();
            if (result.Count == 0)
            {
                return NotFound(new { Message = $"Пользователь с Id = {id} не найден" });
            }
            return Ok(result.First());
        }

        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            return Ok(_storage.users); 
        }

    }
}
