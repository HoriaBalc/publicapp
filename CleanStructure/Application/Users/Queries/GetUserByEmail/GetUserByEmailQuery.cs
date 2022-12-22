﻿using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Queries.GetUserByEmail
{
    public class GetUserByEmailQuery : IRequest<User>
    {
        public string Email { get; set; } = null!;

    }
    
}