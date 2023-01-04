﻿using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities.Queries.GetAllActivities
{
    public class GetAllActivitiesQuery : IRequest<List<ActivityDTO>>
    {

    }
}
