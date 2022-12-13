using Application.Activities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Commands.CreatePaceActivity
{
    public class CreatePaceActivityCommand : IRequest<Guid>
    {
        public PaceActivityDTO dto { get; set; }
    }
    
}
