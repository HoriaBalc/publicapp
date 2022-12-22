using Application.Activities;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PaceActivities
{
    public class PaceActivityDTO : ActivityDTO
    {
        public int Steps { get; set; }

        public PaceActivityDTO() : base()
        {
            Steps = 0;
        }

        public PaceActivityDTO(int duration, DateTime startDate, double distance) : base(duration, startDate, distance)
        {
            Steps = 0;
        }

        public PaceActivityDTO(int duration, DateTime startDate, double distance, int elevationGain, int elevationLoss, float calories) : base(duration, startDate, distance, elevationGain, elevationLoss, calories)
        {
            Steps = 0;
        }

        public void CountSteps()
        {
            //to do
           // Steps = (int)((double)Distance / ((double)(User.Height * 1.0541 / 2)));
        }
    }
}
