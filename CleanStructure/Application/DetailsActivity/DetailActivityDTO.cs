﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DetailsActivity
{
    public class DetailActivityDTO
    {
        public Guid Id { get; private set; }
        //seconds
        public int Duration { get; set; }

        public double Distance { get; set; }

        public int ElevationGain { get; set; }

        public int ElevationLoss { get; set; }

        public double Calories { get; set; }



        public DetailActivityDTO()
        {
            Id = Guid.NewGuid();
        }

        public DetailActivityDTO(int duration, double distance)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            Distance = distance;

        }

        public DetailActivityDTO(int duration, double distance, int elevationGain, int elevationLoss, double calories)
        {
            Id = Guid.NewGuid();
            Duration = duration;
            Distance = distance;
            ElevationGain = elevationGain;
            ElevationLoss = elevationLoss;
            Calories = calories;
        }
    }
}
