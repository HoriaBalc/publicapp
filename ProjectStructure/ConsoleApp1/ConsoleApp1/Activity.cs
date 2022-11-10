using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Activity
    {
        public Guid Id { get; private set; }   
        public DateTime StartDate { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Distance { get; set; }
        public int ElevationGain { get; set; }
        public int ElevationLoss { get; set; }
        public double Calories { get; set; }
        public Sport Sport { get; set; }
        public bool InProgress { get; set; }
        public User User { get; set; }
        public List<DetailActivity> Details { get; set; }
        public Activity(TimeSpan duration, DateTime startDate, decimal distance, Sport sport, User user)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            StartDate = startDate;
            Distance = distance;
            Sport = sport;
            InProgress = true;
            User = user;
            Details = new List<DetailActivity>();
        }

        public Activity(TimeSpan duration, DateTime startDate, decimal distance, int elevationGain, int elevationLoss, double calories, Sport sport, User user)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            StartDate = startDate;
            Distance = distance;
            ElevationGain = elevationGain;
            ElevationLoss = elevationLoss;
            Calories = calories;
            Sport = sport;
            InProgress=true;
            User = user;
            Details = new List<DetailActivity>();
        }

        public void addDetails() {
            if (Details.Count < (int)Distance / 1)
            {
                if (Details.Count == 0)
                {
                    Details.Add(new DetailActivity(Duration, Distance, ElevationGain, ElevationLoss, Calories));
                }
                else {
                    Details.Add(new DetailActivity(Duration - Details[Details.Count-1].Duration, Distance - Details[Details.Count-1].Distance, ElevationGain - Details[Details.Count - 1].ElevationGain, ElevationLoss - Details[Details.Count - 1].ElevationLoss, Calories - Details[Details.Count - 1].Calories));
                }
            }
        }

    }
}
