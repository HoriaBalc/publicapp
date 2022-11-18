using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    public class Cycling : SportActivity
    {
        
        public Cycling(int duration, int distance) : base(duration, distance)
        {

        }
        override
        public decimal CalculateCalories()
        {
            return ((decimal)Distance / (decimal)Duration) * 10;

        }
    }
}
