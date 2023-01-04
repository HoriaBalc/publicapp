using Application;
using Infrastructure.Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity = Domain.Activity;

namespace Infrastructure
{
    public class ActivityRepository : IActivityRepository
    {
      

        private readonly AppDbContext _context;

        public ActivityRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Activity> GetActivity(Guid id)
        {
            var activity = await _context.Activities.SingleOrDefaultAsync(s => s.Id == id);
            return activity;
        }
        public async Task<Guid> CreateActivity(Activity activity)
        {
            await _context.Activities.AddAsync(activity);
            //_context.SaveChanges(); 
            return activity.Id;
        }

        public async Task<Activity> DeleteActivity(Activity activity)
        {
            _context.Activities.Remove(activity);
            return activity;

        }

        public async Task<Activity> UpdateActivity(Activity activity)
        {
            _context.Activities.Update(activity);
            return activity;
        }

        public async Task<List<Activity>> GetActivities()
        {
            var activityList = await _context.Activities.Include(x => x.Sport).ToListAsync();
            return activityList;
        }


    }
}
