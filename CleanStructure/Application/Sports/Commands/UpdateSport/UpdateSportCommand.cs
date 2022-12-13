using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Commands.UpdateSport
{
    public class UpdateSportCommand : IRequest<Sport>
    {
        public SportDTO dto { get; set; }
    }
}
