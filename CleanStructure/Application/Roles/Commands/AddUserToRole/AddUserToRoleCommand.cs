using Application.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Commands.AddUserToRole
{
    public class AddUserToRoleCommand : IRequest<string>
    {
        public string RoleName { get; set; }
        public string UserEmail { get; set; }
    }
    
}
