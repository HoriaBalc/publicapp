using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IRoleRepository
    {
        Task<Role> GetRole(string name);
        Task<string> CreateRole(Role role);
        Task<string> AddUserToRole(string userEmail, string roleName);

        Task<Role> DeleteRole(Role role);
        Task<List<Role>> GetRoles();
        Task<Role> UpdateRole(Role role);

    }
}
