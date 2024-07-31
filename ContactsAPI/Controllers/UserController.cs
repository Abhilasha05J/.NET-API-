using BusinessLogic;
using DataAcces.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ContactsAPI.Controllers
{
    //[EnableCors("AllowLocalhost")]
    [ApiController]
    [Route("api/[controller]")]
   
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userservices)
        {
            _userServices = userservices;
        }
        [HttpGet]
        public async Task<IActionResult> GetUser()

        {
            return Ok(await _userServices.GetUser());
        }

        [HttpPost]
        public IActionResult AddUser(UserDetails userdetails)
        {

            return Ok(_userServices.AddUser(userdetails));
        }

        [HttpGet("{id}")]
        public IActionResult GetAddressById(int id)
        {
            return Ok(_userServices.GetUserById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            return Ok(_userServices.DeleteUser(id));

        }
        [HttpPut("{id}")]
        public IActionResult UpdateAddress(int id, UserDetails user)
        {
            return Ok(_userServices.UpdateUser(id, user));
        }
    }
}
