using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    public class FactoryActivity
    {
        public ISportActivity CreateActivity(int count, int duration, int distance)
        {
            if (count == 1) 
            {
                return new Running(duration, distance);
            }
            if (count == 2)
            {
                return new Walking(duration, distance);
            }
            if (count == 3)
            {
                return new Cycling(duration, distance);
            }
            return new Running(duration, distance);

        }
    }
}
