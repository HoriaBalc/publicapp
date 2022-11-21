using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Activity
    {
        public int Duration { get; set; }
        public int Distance { get; set; }

        public Activity( int duration, int distance) 
        {
            Distance = distance;
            Duration = duration;
        }
        public void ActivityAnalize() 
        {
            CalculateAverageSpeed();
            int steps = CalculateSteps();
            Console.WriteLine($"{steps} steps");
            CalculateCalories(steps);
        }

        protected virtual void CalculateAverageSpeed() 
        {
            int speed = Distance / Duration;
            Console.WriteLine($"speed:{speed}");
        }
        protected abstract void CalculateCalories( int steps);
        protected abstract int CalculateSteps();


    }
}
