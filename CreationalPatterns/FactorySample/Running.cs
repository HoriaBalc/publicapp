using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    public class Running : SportActivity
    {
        public int Steps { get; set; }
        public Running(int duration, int distance) : base(duration, distance)
        {
            Steps = 0;
        }
        override
        public decimal CalculateCalories()
        {
            return ((decimal)Distance / (decimal)Duration) * 20;
        }

       

    }
}
