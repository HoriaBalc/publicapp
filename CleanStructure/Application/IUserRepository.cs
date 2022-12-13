using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IUserRepository
    {
        Task<User> GetUser(string email);
        Task<User> GetUserById(Guid id);
        Task<List<User>> GetUsers();
        Task<string> CreateUser(User user);
        Task<User> DeleteUser(User user);
        Task<User> UpdateUser(User user);

    }
}
