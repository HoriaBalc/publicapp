using Application.Activities;
using Application.DTOs;
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
        public PaceActivityDTOCreateUpdate dto { get; set; }
      
    }
    
}
