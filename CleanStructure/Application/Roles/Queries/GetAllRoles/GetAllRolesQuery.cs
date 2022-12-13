using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Roles.Queries.GetAllRoles
{
    public class GetAllRolesQuery : IRequest<List<Role>>
    {

    }
   
}
