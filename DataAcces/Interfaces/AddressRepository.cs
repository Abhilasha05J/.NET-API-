
using DataAcces.Data;
using DataAcces.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAcces.Interfaces
{
    public  class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AddressRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Address AddAddressAsync(Address address)
        {
            var newAddress = new Address()
            {

                Country = address.Country,
                State = address.State,
                city = address.city

            };
            var  createdAddress =  _dbContext.Add(newAddress);
            _dbContext.SaveChanges();


            return newAddress;

        }

        public async Task<IEnumerable<Address>> GetAddressAsync()
        {
            return await _dbContext.Address.ToListAsync();
        }

       public string DeleteAddressAsync(int id)
        {
            var address =  _dbContext.Address.Find(id);
            if (address != null)
            {
                _dbContext.Remove(address);
                _dbContext.SaveChanges();
                return "Deleted Successfully";
            }
            return ".";
           
        }

        public Address GetAddressByIdAsync(int id)
        {
            // throw new NotImplementedException();
            var address = _dbContext.Address.Find(id);
            if (address == null)
            {
                throw new Exception("Address not Found");
            }
            return address;
        }

        public Address UpdateAddressAsync(int id, Address address)
        {
            // throw new NotImplementedException();
            var newaddress = _dbContext.Address.Find(id);
            if (newaddress != null)
            {
                newaddress.Country = address.Country;
                newaddress.State = address.State;
                newaddress.city = address.city;

                _dbContext.SaveChanges();
                return newaddress;
            }
            throw new Exception("Address not Found");
        }
    }
}
