using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
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

        Task<Address> IAddressServices.AddAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }

        Task IAddressServices.DeleteAddressAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Address> IAddressServices.GetAddressByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Address> IAddressServices.UpdateAddressAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}


