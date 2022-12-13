using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Application.Sports;

namespace Application
{
    public class CreateSportCommand : IRequest<string>
    {        
       public SportDTO dto  { get; set; }
        //public List<SportDTO> Sports { get; set; } = new();
    }
}
