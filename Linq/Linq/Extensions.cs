using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class Extensions
    {
        public static void SetActivity(this Activity activity, DateTime startDate, TimeSpan duration, decimal distance, int elevationGain, int elevationLoss, double calories, bool inProgress)
        {
            activity.StartDate = startDate;
            activity.Duration = duration;
            activity.Distance = distance;
            activity.ElevationGain = elevationGain;
            activity.ElevationLoss = elevationLoss;
            activity.Calories = calories;
            activity.InProgress = inProgress;
            activity.Details = new List<DetailActivity>();
        }
        public static void SetDetailActivity(this DetailActivity detail, TimeSpan duration, decimal distance, int elevationGain, int elevationLoss, double calories)
        {
            detail.Duration = duration;
            detail.Distance = distance;
            detail.ElevationGain = elevationGain;
            detail.ElevationLoss = elevationLoss;
            detail.Calories = calories;
          
        }

        public static DateTime DateSample() {
            return DateTime.Now;
        }

        public static TimeSpan TimeSample(int hours, int minutes, int seconds)
        {
            return new TimeSpan(hours, minutes, seconds);

        }

        public static void AddDetail(this Activity activity, DetailActivity detailActivity) 
        {
            activity.Details.Add(detailActivity);
        }


    }
}
