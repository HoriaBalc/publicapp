using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemoryPaceActivity : IPaceActivityRepository
    {
        private readonly List<PaceActivity> _activities = new();
        public PaceActivity GetPaceActivity(Guid id)
        {
            foreach (PaceActivity activity in _activities)
            {
                if (activity.Id.Equals(id))
                    return activity;
            }
            return new PaceActivity();
        }
        public void CreatePaceActivity(PaceActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
