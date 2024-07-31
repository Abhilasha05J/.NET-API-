using BusinessLogic;
using ContactsAPI.Models;
using DataAcces.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : Controller
    {
        private readonly IAddressServices _addressService;

            public AddressController(IAddressServices addressService)
            {
                _addressService = addressService;
            }
        [HttpGet]  
        public async Task<IActionResult> GetAddressAsync()

            {
                return Ok(await _addressService.GetAddressAsync());
            }

        [HttpPost]
        public IActionResult AddAddress(Address address)
        {
           
            return Ok(_addressService.AddAddressAsync(address));
        }

        [HttpGet("{id}")]
        public IActionResult GetAddressById(int id) 
        {
            return Ok(_addressService.GetAddressByIdAsync(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            return Ok(_addressService.DeleteAddressAsync(id));
           
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAddress(int id, Address address)
        {
            return Ok(_addressService.UpdateAddressAsync(id, address));
        }
    }
}
