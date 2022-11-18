using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PaceActivity : Activity
    {       
        public int Steps { get; set; }

        public PaceActivity() : base()
        {
            Steps = 0;
        }

        public PaceActivity(TimeSpan duration, DateTime startDate, decimal distance, Sport sport, User user) : base(duration, startDate, distance, sport, user)
        {
            Steps = 0;
        }

        public PaceActivity(TimeSpan duration, DateTime startDate, decimal distance, int elevationGain, int elevationLoss, float calories, Sport sport, User user) : base( duration, startDate, distance, elevationGain, elevationLoss, calories, sport,user)
        {
            Steps = 0;
        }

        public void CountSteps() 
        {
            //provisionally solution
            Steps = (int) ((double) Distance / ((double) (User.Height * 1.0541/2)));
        }



    }
}
