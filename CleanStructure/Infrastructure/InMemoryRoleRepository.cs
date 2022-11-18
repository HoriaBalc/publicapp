using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemoryRoleRepository : IRoleRepository
    {
        private readonly List<Role> _roles = new();
        public Role GetRole(string name)
        {
            foreach (Role role in _roles)
            {
                if (role.Name.Equals(name))
                    return role;
            }
            return new Role(name);
        }
        public void CreateRole(Role role)
        {
            _roles.Add(role);
        }
    }
}
