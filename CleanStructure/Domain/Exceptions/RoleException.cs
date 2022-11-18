using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class RoleException:Exception
    {
        public string ErrorCode { get; }
        public RoleException() 
        {
        }
        public RoleException(string message):base(message)
        {
        }

    }
}
