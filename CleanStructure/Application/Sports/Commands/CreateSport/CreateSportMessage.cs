﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sports.Commands.CreateSport
{
    public class CreateSportMessage : IRequest<Guid>
    {
        public string Name { get; set; } = null!;
    }
}