
using DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Interfaces
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAddressAsync();
        public Address GetAddressByIdAsync(int id);
        public Address AddAddressAsync(Address address);
        public Address UpdateAddressAsync(int id, Address address);
        public string DeleteAddressAsync(int id);
    }
}
