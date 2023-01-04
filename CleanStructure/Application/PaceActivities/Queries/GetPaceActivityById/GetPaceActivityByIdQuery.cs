using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Queries.GetPaceActivityById
{
    public class GetPaceActivityByIdQuery : IRequest<PaceActivityDTO>
    {
        public Guid Id { get; set; }

    }
    
}
