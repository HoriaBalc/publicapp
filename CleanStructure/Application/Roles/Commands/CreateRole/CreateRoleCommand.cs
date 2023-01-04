using Application.DTOs;
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
        public NameDTO dto { get; set; }
    }
    
}
