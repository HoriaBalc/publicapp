using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Commands.DeleteDetailsActivity
{
    public class DeleteDetailsActivityCommand : IRequest<DetailActivity>
    {
        public Guid Id { get; set; }
    }
   
}
