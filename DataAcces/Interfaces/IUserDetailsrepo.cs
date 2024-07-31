using DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Interfaces
{
    public interface IUserDetailsrepo
    {
        Task<IEnumerable<UserDetails>> GetUser();
        public UserDetails GetUserById(int id);
        public UserDetails AddUser(UserDetails user);
        public UserDetails UpdateUser(int id, UserDetails user);
        public UserDetails DeleteUser(int id);
    }
}
