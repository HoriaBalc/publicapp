

using Application;
using Infrastructure.Data;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<User> GetUser(string email)
        {
            var user = await _context.Users.SingleOrDefaultAsync(s => s.Email == email);
            return user;
        }

        public async Task<User> GetUserById(Guid id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(s => s.Id == id);
            return user;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _context.Users.SingleOrDefaultAsync(s => s.Email == email);
            return user;
        }

        public async Task<string> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            return user.Email;
        }

        public async Task<User> DeleteUser(User user)
        {
            _context.Users.Remove(user);
            return user;
                                                                                                        
        }

        public async Task<User> UpdateUser(User user)
        {
            _context.Users.Update(user);
            return user;
        }

        public async Task<List<User>> GetUsers()
        {
            var userList = await _context.Users.ToListAsync();
            return userList;
        }


    }
}