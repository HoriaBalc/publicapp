﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class UserException:Exception
    {
        public string ErrorCode { get; }

        public UserException()
        {
        }

        public UserException(string message) : base(message)
        {
        }
    }
}
