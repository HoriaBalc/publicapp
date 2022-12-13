using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities.Commands.DeletePaceActivity
{
    public class DeletePaceActivityCommand : IRequest<PaceActivity>
    {
        public Guid Id { get; set; }
    }
    
}
