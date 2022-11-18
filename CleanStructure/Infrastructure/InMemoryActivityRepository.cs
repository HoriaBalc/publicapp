using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemoryActivityRepository : IActivityRepository
    {
        private readonly List<Activity> _activities = new();
        public Activity GetActivity(Guid id)
        {
            foreach (Activity activity in _activities)
            {
                if (activity.Id.Equals(id))
                    return activity;
            }
            return new Activity();
        }
        public void CreateActivity(Activity activity)
        {
            _activities.Add(activity);
        }
    }
}
