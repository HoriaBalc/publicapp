using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class PaceActivityException : ActivityException
    {
        public string ErrorCode { get; }
        public PaceActivityException() 
        {
        }
        public PaceActivityException(string message):base(message)
        {
        }
    }
}
