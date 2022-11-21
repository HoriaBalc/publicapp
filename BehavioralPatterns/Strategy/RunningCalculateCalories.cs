using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RunningCalculateCalories : ICalculateCaloriesStrategy
    {

        public decimal CalculateCalories(int duration, int distance)
        {
            return ((decimal)distance / duration) * 17; 
        }
    }
}
