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
        public Guid Id { get; private set; }

        public DateTime StartDate { get; set; }

        //seconds
        public int Duration { get; set; }

        public double Distance { get; set; }

        public int ElevationGain { get; set; }

        public int ElevationLoss { get; set; }

        public double Calories { get; set; }

        public bool InProgress { get; set; }

        
        public ActivityDTO()
        {
            Id = Guid.NewGuid();
        }
        public ActivityDTO(int duration, DateTime startDate, double distance)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            StartDate = startDate;
            Distance = distance;
            InProgress = true;
        }

        public ActivityDTO(int duration, DateTime startDate, double distance, int elevationGain, int elevationLoss, double calories) : this(duration, startDate, distance)
        {
            ElevationGain = elevationGain;
            ElevationLoss = elevationLoss;
            Calories = calories;

        }

        //public void AddDetails()
        //{
        //    if (Details.Count < (int)Distance / 1)
        //    {
        //        if (Details.Count == 0)
        //        {
        //            Details.Add(new DetailActivity(Duration, Distance, ElevationGain, ElevationLoss, Calories));
        //        }
        //        else
        //        {
        //            Details.Add(new DetailActivity(Duration - Details[Details.Count - 1].Duration, Distance - Details[Details.Count - 1].Distance, ElevationGain - Details[Details.Count - 1].ElevationGain, ElevationLoss - Details[Details.Count - 1].ElevationLoss, Calories - Details[Details.Count - 1].Calories));
        //        }
        //    }
        //}
    }
}
