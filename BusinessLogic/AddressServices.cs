using DataAcces.Entities;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AddressServices : IAddressServices
    {
        private readonly IAddressRepository _addressRepository;

        public AddressServices(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<IEnumerable<Address>> GetAddressAsync()
        {
            return await _addressRepository.GetAddressAsync();
        }

        public Address AddAddressAsync(Address address)
        {
            return  _addressRepository.AddAddressAsync(address);
        }

        public Address GetAddressByIdAsync(int id)
        {
            return _addressRepository.GetAddressByIdAsync(id);
        }

        public Address UpdateAddressAsync(int id, Address address)
        {
            return _addressRepository.UpdateAddressAsync(id, address);
        }

        public string DeleteAddressAsync(int id)
        {
            return  _addressRepository.DeleteAddressAsync(id);
        }
    }
}


