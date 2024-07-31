using DataAcces.Entities;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserServices : IUserServices
    {
        private readonly IUserDetailsrepo _userDetailsrepo;

        public UserServices(IUserDetailsrepo userDetailsrepo)
        {
            _userDetailsrepo = userDetailsrepo;
        }
        public UserDetails AddUser(UserDetails user)
        {
            return _userDetailsrepo.AddUser(user);
        }

        public UserDetails DeleteUser(int id)
        {
            return _userDetailsrepo.DeleteUser(id);
        }

        public async Task<IEnumerable<UserDetails>> GetUser()
        {
            return await _userDetailsrepo.GetUser();
        }

        public UserDetails GetUserById(int id)
        {
           return _userDetailsrepo.GetUserById(id);
        }

        public UserDetails UpdateUser(int id, UserDetails user)
        {
            return (_userDetailsrepo.UpdateUser(id, user));
        }
    }
}
