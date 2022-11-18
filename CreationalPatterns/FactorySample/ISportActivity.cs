using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    public interface ISportActivity
    {
        public abstract decimal CalculateCalories();
        public abstract decimal AverageSpeed();

    }
}
