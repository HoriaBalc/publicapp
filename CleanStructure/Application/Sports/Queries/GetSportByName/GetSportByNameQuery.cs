using Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Application
{
    public class GetSportByNameQuery : IRequest<Sport>
    {
        public string Name { get; set; } = null!;

    }
}
