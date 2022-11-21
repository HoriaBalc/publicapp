using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CalculateCaloriesContext
    {
        private ICalculateCaloriesStrategy _strategy;

        public void SetStrategy(ICalculateCaloriesStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateCalories(int duration, int distance)
        {
            if (_strategy != null) 
                return _strategy.CalculateCalories(duration, distance);
            return 0;
        }
    }
}
