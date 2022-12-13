using Application.Activities;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Commands.UpdatePaceActivity
{
    public class UpdatePaceActivityCommand : IRequest<PaceActivity>
    {
        public PaceActivityDTO dto { get; set; }
    }
    
}
