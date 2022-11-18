using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class DetailActivityException:Exception
    {
        public string ErrorCode { get; }
        public DetailActivityException() 
        {
        }
        public DetailActivityException(string message):base(message)
        {
        }

    }
}
