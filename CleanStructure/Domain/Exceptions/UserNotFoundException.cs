﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class UserNotFoundException: UserException
    {
        public string ErrorCode { get; }

        public UserNotFoundException() 
        { 
        }

        public UserNotFoundException(string message):base(message)
        {
        }

    }
}
