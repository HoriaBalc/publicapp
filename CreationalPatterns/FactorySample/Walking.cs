using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    public class Walking : SportActivity
    {
        public int Steps { get; set; }
        public Walking(int duration, int distance):base(duration, distance)
        {
            Steps = 0;
        }
        override
        public decimal CalculateCalories()
        {
            return ((decimal)Distance / (decimal)Duration) * 15;
        }

       

    }
}
