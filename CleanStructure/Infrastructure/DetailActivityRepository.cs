using Application;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DetailActivityRepository : IDetailActivityRepository
    {

        private readonly AppDbContext _context;
        public async Task<DetailActivity> GetDetailActivity(Guid id)
        {
            var activity = await _context.DetailActivities.SingleOrDefaultAsync(s => s.Id == id);
            return activity;
        }
        public async Task<Guid> CreateDetailActivity(DetailActivity activity)
        {
            await _context.DetailActivities.AddAsync(activity);
            //_context.SaveChanges(); 
            return activity.Id;
        }

        public async Task<DetailActivity> DeleteDetailActivity(DetailActivity activity)
        {
            _context.DetailActivities.Remove(activity);
            return activity;

        }

        public async Task<DetailActivity> UpdateDetailActivity(DetailActivity activity)
        {
            _context.DetailActivities.Update(activity);
            return activity;
        }

        public async Task<List<DetailActivity>> GetDetailActivities()
        {
            var activityList = await _context.DetailActivities.Take(100).ToListAsync();
            return activityList;
        }
    }
}
