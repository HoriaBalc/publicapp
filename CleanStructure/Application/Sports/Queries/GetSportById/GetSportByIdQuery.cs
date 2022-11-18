using Application.Sports.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Queries.GetSportById
{
    public class GetSportByIdQuery : IRequest<SportDTO>
    {

    }
}
