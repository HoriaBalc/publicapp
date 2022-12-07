using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Commands.DeleteSport
{
    public class DeleteSportCommand : IRequest<Sport>
    {
        public string Name { get; set; } = null!;
    }
}
