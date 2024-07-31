﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IAddressServices
    {
        Task<IEnumerable<Address>> GetAddressAsync();
        Task<Address> GetAddressByIdAsync(int id);
        Task<Address> AddAddressAsync(Address address);
        Task<Address> UpdateAddressAsync(Address address);
        Task DeleteAddressAsync(int id);
    }
}
