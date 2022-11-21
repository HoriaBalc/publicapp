using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Running : Activity
    {
        public Running( int duration, int distance) : base( duration, distance)
        {
        }
        protected override void CalculateCalories(int steps)
        {
             int calories= (int)((decimal)Distance / Duration * 17 * ((decimal)steps/Distance));
            Console.WriteLine($"Calories: {calories}");
        }

        protected override int CalculateSteps()
        {
            return (int)(Distance * 1.4);
        }
    }
}
