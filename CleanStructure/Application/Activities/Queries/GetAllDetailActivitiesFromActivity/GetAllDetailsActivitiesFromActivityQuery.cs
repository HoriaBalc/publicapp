using Application.DetailsActivity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Queries.GetAllDetailActivitiesFromActivity
{
    public class GetAllDetailsActivitiesFromActivityQuery : IRequest<List<DetailActivityDTO>>
    {
        public Guid Id { get; set; }
    }
}
