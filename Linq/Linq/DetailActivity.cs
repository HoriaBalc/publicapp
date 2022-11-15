using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
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
    }
}
