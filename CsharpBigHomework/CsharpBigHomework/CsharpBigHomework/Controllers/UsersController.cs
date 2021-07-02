using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CsharpBigHomework.Models;
using CsharpBigHomework.Service;

namespace CsharpBigHomework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        UserService userService;

        public UsersController(BBSContext context)
        {
            userService = new UserService(context);
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            var query = userService.GetUsers();
            return query.ToList();
        }

        // GET: api/Users/{id}
        [HttpGet("{id}")]
        public ActionResult<User> DetailsByUserId(string id)
        {
            var user = userService.FindUserByUserId(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // GET: api/Users/name/{name}
        [HttpGet("name/{name}")]
        public ActionResult<User> DetailsByUserName(string name)
        {
            var user = userService.FindUserByName(name);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // POST: api/Users
        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            try
            {
                userService.AddUser(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return user;
        }

        // PUT: api/Users
        [HttpPut("{id}")]
        public ActionResult<User> Edit(string id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                userService.ChangeUser(user);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                userService.DeleteUser(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
