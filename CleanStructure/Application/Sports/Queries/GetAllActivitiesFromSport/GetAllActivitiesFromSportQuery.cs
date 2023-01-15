using Application.Activities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Queries.GetAllActivitiesFromSport
{
    public class GetAllActivitiesFromSportQuery : IRequest<List<ActivityDTO>>
    {
        public string Name { get; set; } = null!;
    }
}
