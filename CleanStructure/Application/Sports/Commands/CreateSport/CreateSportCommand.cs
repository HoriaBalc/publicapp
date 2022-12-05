using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateSportCommand : IRequest<Guid>
    {
        public string Name { get; set; } = null!;
        //public List<SportDTO> Sports { get; set; } = new();
    }
}
