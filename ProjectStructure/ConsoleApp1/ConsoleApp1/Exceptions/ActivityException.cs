using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class ActivityException:Exception
    {
        public string ErrorCode { get; }
        public ActivityException() 
        { 
        }

        public ActivityException(string message):base(message)
        {
        }
    }
}
