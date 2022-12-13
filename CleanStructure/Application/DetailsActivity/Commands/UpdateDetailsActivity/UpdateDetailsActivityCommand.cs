using Application.Activities;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Commands.UpdateDetailsActivity
{
    public class UpdateDetailsActivityCommand : IRequest<DetailActivity>
    {
        public DetailActivityDTO dto { get; set; }
    }
    
}
