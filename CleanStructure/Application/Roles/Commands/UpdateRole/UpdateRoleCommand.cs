using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Commands.UpdateRole
{
    public class UpdateRoleCommand : IRequest<Role>
    {
        public RoleDTO dto { get; set; }
    }
   
}
