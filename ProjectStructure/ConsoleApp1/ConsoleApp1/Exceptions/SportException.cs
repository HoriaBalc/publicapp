using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class SportException:Exception
    {
        public string ErrorCode { get; }
        public SportException() 
        {
        }
        public SportException(string message):base(message) 
        {
        }

    }
}
