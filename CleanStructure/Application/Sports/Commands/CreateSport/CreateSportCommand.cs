using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Application.Sports;
using Application.DTOs;

namespace Application
{
    public class CreateSportCommand : IRequest<string>
    {        
       public NameDTO dto  { get; set; }
    }
}
