﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
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
        
        public List<DetailActivity> Details { get; private set; }
        public Activity()
        {
            Id = Guid.NewGuid();
        }
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

        public Activity(TimeSpan duration, DateTime startDate, decimal distance, int elevationGain, int elevationLoss, double calories, Sport sport, User user):this(duration,startDate,distance,sport,user)
        {
            ElevationGain = elevationGain;
            ElevationLoss = elevationLoss;
            Calories = calories;
            
        }

        public void AddDetails() {
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
