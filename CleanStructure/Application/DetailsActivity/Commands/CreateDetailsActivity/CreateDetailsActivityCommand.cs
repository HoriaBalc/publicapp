using Application.Activities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Commands.CreateDetailsActivity
{
    public class CreateDetailsActivityCommand : IRequest<Guid>
    {
        public DetailActivityDTO dto { get; set; }
    }
    
}
