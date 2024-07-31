using DataAcces.Data;
using DataAcces.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Interfaces
{
    public class UserDetailsRepo : IUserDetailsrepo
    {
        private readonly ApplicationDbContext _dbContext;

        public UserDetailsRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        Entities.UserDetails IUserDetailsrepo.AddUser(Entities.UserDetails user)
        {
            var newUser = new Entities.UserDetails()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                MobileNumber = user.MobileNumber,
                EnterPassword = user.EnterPassword,
                ConfirmPassword = user.ConfirmPassword,


            };
            var createdAddress = _dbContext.Add(newUser);
            _dbContext.SaveChanges();


            return newUser;
        }

        UserDetails IUserDetailsrepo.DeleteUser(int id)
        {
            var user = _dbContext.UserDetails.Find(id);
            if (user != null)
            {
                _dbContext.Remove(user);
                _dbContext.SaveChanges();
                return user;
            }
            throw new Exception("user not Found");
        }

        async Task<IEnumerable<Entities.UserDetails>> IUserDetailsrepo.GetUser()
        {
            return await _dbContext.UserDetails.ToListAsync();
        }

        Entities.UserDetails IUserDetailsrepo.GetUserById(int id)
        {
            // throw new NotImplementedException();
            var user = _dbContext.UserDetails.Find(id);
            if (user == null)
            {
                throw new Exception("user not Found");
            }
            return user;
        }

            Entities.UserDetails IUserDetailsrepo.UpdateUser(int id, Entities.UserDetails user)
        {
            var newUser = _dbContext.UserDetails.Find(user.Id);
                if (newUser != null)
                {
                newUser.FirstName = user.FirstName;
                newUser.LastName = user.LastName;
                newUser.Email = user.Email;
                newUser.MobileNumber = user.MobileNumber;
                newUser.EnterPassword = user.EnterPassword;
                newUser.ConfirmPassword = user.ConfirmPassword;
                    return newUser;
                }
                throw new Exception("User not Found");
            }
    }
}
