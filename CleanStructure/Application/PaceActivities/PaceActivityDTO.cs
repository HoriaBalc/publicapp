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

        public PaceActivityDTO(TimeSpan duration, DateTime startDate, double distance, Sport sport, User user) : base(duration, startDate, distance, sport, user)
        {
            Steps = 0;
        }

        public PaceActivityDTO(TimeSpan duration, DateTime startDate, double distance, int elevationGain, int elevationLoss, float calories, Sport sport, User user) : base(duration, startDate, distance, elevationGain, elevationLoss, calories, sport, user)
        {
            Steps = 0;
        }

        public void CountSteps()
        {
            //provisionally solution
            Steps = (int)((double)Distance / ((double)(User.Height * 1.0541 / 2)));
        }
    }
}
