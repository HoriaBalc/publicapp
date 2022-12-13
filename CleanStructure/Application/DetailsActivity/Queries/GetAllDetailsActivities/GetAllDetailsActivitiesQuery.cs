using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity.Queries.GetAllDetailsActivities
{
    public class GetAllDetailsActivitiesQuery : IRequest<List<DetailActivity>>
    {

    }
}
