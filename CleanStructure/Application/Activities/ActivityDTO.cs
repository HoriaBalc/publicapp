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

        public TimeSpan Duration { get; set; }

        public double Distance { get; set; }

        public int ElevationGain { get; set; }

        public int ElevationLoss { get; set; }

        public double Calories { get; set; }

        public virtual Sport Sport { get; set; }

        public bool InProgress { get; set; }

        public virtual User User { get; set; }

        public List<DetailActivity> Details { get; private set; }
        public ActivityDTO()
        {
            Id = Guid.NewGuid();
        }
        public ActivityDTO(TimeSpan duration, DateTime startDate, double distance, Sport sport, User user)
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

        public ActivityDTO(TimeSpan duration, DateTime startDate, double distance, int elevationGain, int elevationLoss, double calories, Sport sport, User user) : this(duration, startDate, distance, sport, user)
        {
            ElevationGain = elevationGain;
            ElevationLoss = elevationLoss;
            Calories = calories;

        }

        public void AddDetails()
        {
            if (Details.Count < (int)Distance / 1)
            {
                if (Details.Count == 0)
                {
                    Details.Add(new DetailActivity(Duration, Distance, ElevationGain, ElevationLoss, Calories));
                }
                else
                {
                    Details.Add(new DetailActivity(Duration - Details[Details.Count - 1].Duration, Distance - Details[Details.Count - 1].Distance, ElevationGain - Details[Details.Count - 1].ElevationGain, ElevationLoss - Details[Details.Count - 1].ElevationLoss, Calories - Details[Details.Count - 1].Calories));
                }
            }
        }
    }
}
