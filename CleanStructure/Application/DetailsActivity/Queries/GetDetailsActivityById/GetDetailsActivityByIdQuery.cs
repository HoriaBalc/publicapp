using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Queries.GetDetailsActivityById
{
    public class GetDetailsActivityByIdQuery : IRequest<DetailActivity>
    {
        public Guid Id { get; set; }

    }
   
}
