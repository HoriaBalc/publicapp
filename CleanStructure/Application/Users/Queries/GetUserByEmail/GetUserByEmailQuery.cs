﻿using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Queries.GetUserByEmail
{
    public class GetUserByEmailQuery : IRequest<UserDTO>
    {
        public string Email { get; set; } = null!;

    }
    
}
