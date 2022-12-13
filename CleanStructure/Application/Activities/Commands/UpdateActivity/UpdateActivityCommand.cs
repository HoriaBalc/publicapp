using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Commands.UpdateActivity
{
    public class UpdateActivityCommand : IRequest<Activity>
    {
        public ActivityDTO dto { get; set; }
    }
   
}
