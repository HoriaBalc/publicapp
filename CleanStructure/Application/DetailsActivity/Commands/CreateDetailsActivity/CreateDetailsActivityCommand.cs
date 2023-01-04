using Application.Activities;
using Application.DTOs;
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
        public DetailsActivityDTOCreateUpdate dto { get; set; }
    }
    
}
