using Application;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContext _context;

        public RoleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Role> GetRole(string name)
        {
            var role = await _context.Roles.SingleOrDefaultAsync(s => s.Name == name);
            return role;
        }
        public  async Task<string> CreateRole(Role role)
        {
             await _context.Roles.AddAsync(role);
            //_context.SaveChanges(); 
            return role.Name;
        }

        public async Task<Role> DeleteRole(Role role)
        {
            _context.Roles.Remove(role);
            return role;
            
        }

        public async Task<Role> UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            return role;
        }

        public async Task<List<Role>> GetRoles()
        {
            var roleList = await _context.Roles.Take(100).ToListAsync();
            return roleList;
        }

    }
}
