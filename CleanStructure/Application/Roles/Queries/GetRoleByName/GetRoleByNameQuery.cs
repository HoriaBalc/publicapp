using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Queries.GetRoleByName
{
    public class GetRoleByNameQuery : IRequest<RoleDTO>
    {
        public string Name { get; set; } = null!;

    }
    
}
