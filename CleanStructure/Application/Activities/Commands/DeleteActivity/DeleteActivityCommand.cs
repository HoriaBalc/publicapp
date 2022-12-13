using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Commands.DeleteActivity
{
    public class DeleteActivityCommand : IRequest<Activity>
    {
        public Guid Id { get; set; }
    }
  
}
