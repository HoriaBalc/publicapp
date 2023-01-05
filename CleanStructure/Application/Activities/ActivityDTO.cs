using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities
{

    public class ActivityDTO
    {
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }

        //seconds
        public int Duration { get; set; }

        public double Distance { get; set; }

        public int ElevationGain { get; set; }

        public int ElevationLoss { get; set; }

        public double Calories { get; set; }

        public bool InProgress { get; set; }

       
    }
}
