using Application;
using Infrastructure.Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class PaceActivityRepository : IPaceActivityRepository
    {

        private readonly AppDbContext _context;

        public PaceActivityRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<PaceActivity> GetPaceActivity(Guid id)
        {
            var activity = await _context.PaceActivities.SingleOrDefaultAsync(s => s.Id == id);
            return activity;
        }
        public async Task<Guid> CreatePaceActivity(PaceActivity activity)
        {
            await _context.PaceActivities.AddAsync(activity);
            //_context.SaveChanges(); 
            return activity.Id;
        }

        public async Task<PaceActivity> DeletePaceActivity(PaceActivity activity)
        {
            _context.PaceActivities.Remove(activity);
            return activity;

        }

        public async Task<PaceActivity> UpdatePaceActivity(PaceActivity activity)
        {
            _context.PaceActivities.Update(activity);
            return activity;
        }

        public async Task<List<PaceActivity>> GetPaceActivities()
        {
            var activityList = await _context.PaceActivities.Take(100).ToListAsync();
            return activityList;
        }
    }
}
