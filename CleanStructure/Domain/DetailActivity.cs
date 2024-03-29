﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DetailActivity
    {
        public Guid Id { get; private set; }
        //seconds
        public int Duration { get; set; }
        
        public double Distance { get; set; }
        
        public int ElevationGain { get; set; }
        
        public int ElevationLoss { get; set; }
        
        public double Calories { get; set; }

        public Activity Activity { get; set; }


        public DetailActivity()
        {

        }

        public DetailActivity(int duration, double distance, Activity activity)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            Distance = distance;
            Activity = activity;

        }

        public DetailActivity(int duration, double distance, int elevationGain, int elevationLoss, double calories)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            Distance = distance;
            ElevationGain = elevationGain;
            ElevationLoss = elevationLoss;
            Calories = calories;          
        }

        public DetailActivity(int duration, double distance, int elevationGain, int elevationLoss, double calories, Activity activity) : this(duration, distance, elevationGain, elevationLoss, calories)
        {
            Activity = activity;
        }
    }
}
