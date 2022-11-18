using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DetailActivity
    {
        public Guid Id { get; private set; }
        
        public TimeSpan Duration { get; set; }
        
        public decimal Distance { get; set; }
        
        public int ElevationGain { get; set; }
        
        public int ElevationLoss { get; set; }
        
        public double Calories { get; set; }

        public DetailActivity()
        {
            Id = Guid.NewGuid();
        }

        public DetailActivity(TimeSpan duration, decimal distance)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            Distance = distance;
            
        }

        public DetailActivity(TimeSpan duration, decimal distance, int elevationGain, int elevationLoss, double calories)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            Distance = distance;
            ElevationGain = elevationGain;
            ElevationLoss = elevationLoss;
            Calories = calories;          
        }


    }
}
