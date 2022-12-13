using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Queries.GetActivityById
{
    public class GetActivityByIdQuery : IRequest<Activity>
    {
        public Guid Id { get; set; }

    }
    
}
