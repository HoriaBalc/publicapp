using Application.Activities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Queries.GetAllActivitiesFromUser
{
    public class GetAllActivitiesFromUserQuery : IRequest<List<ActivityDTO>>
    {
        public string Email { get; set; } = null!;

    }
}
