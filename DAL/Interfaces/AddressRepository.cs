using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public  class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AddressRepository(ApplicationDbContext _dbContext)
        {
            _dbContext = _dbContext;
        }

        public Task<Address> AddAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAddressAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Address>> GetAddressAsync()
        {
            return await _dbContext.Address.ToListAsync();
        }

        public Task<Address> GetAddressByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Address> UpdateAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
