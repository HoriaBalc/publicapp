using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateRoleCommand : IRequest<string>
    {
        public RoleDTO dto { get; set; }
        //public List<SportDTO> Sports { get; set; } = new();
    }
    
}
