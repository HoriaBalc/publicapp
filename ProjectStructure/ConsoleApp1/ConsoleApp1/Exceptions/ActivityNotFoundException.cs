using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class ActivityNotFoundException: ActivityException
    {
        public string ErrorCode { get; }
        public ActivityNotFoundException() 
        {
        }
        public ActivityNotFoundException(string message):base(message)
        {
        }
    }
}
