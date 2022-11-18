using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    public abstract class SportActivity : ISportActivity
    {
        public Guid Id { get; private set; }
        public int Duration { get; set; }
        public int Distance { get; set; }
        public SportActivity(int duration, int distance) 
        {
            Id = Guid.NewGuid();
            Duration = duration;
            Distance = distance;
        }

        public abstract decimal CalculateCalories();

        public decimal AverageSpeed()
        {
            return ((decimal)Distance / (decimal)Duration);
        }


    }
}
